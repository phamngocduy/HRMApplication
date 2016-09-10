using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace HRM.Databases
{
    class Foreign
    {
        public Foreign(object name, object table, object column)
        {
            Name = (string)name;
            Table = (Table)table;
            Column = (Column)column;
        }
        public string Name { get; set; }
        public Table Table { get; set; }
        public Column Column { get; set; }
        public bool add = false, mod = false;
        public Foreign OBJ = null;
        public override bool Equals(object obj)
        {
            var FK = OBJ = obj as Foreign;
            if (FK == null)
                return !(add = true);
            return !(mod = !(Name == FK.Name && Table.Name == FK.Table.Name && Column.Name == FK.Column.Name));
        }
        public override string ToString()
        {
            return Table.Name + "_" + Column.Name + ": " + Name;
        }
    }
    class Column
    {
        public Column(object name, object type, object length, object nullable)
        {
            Name = (string)name;
            Type = (string)type;
            Size = (int)length;
            Null = (short)nullable > 0 ? true : false;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public bool Null { get; set; }
        public Foreign Foreign { get; set; }
        public bool add = false, mod = false;
        public Column OBJ = null;
        public override bool Equals(object obj)
        {
            var COL = OBJ = obj as Column;
            if (COL == null)
                return !(add = true);
            if (Foreign != null && !Foreign.Equals(COL.Foreign))
                return !(mod = true);
            return !(mod = !(Name == COL.Name && Type == COL.Type && Size == COL.Size && Null == COL.Null));
        }
        public override string ToString()
        {
            return Name + ", " + Type + ", " + Size + ", " + Null;
        }
    }
    class Table
    {
        public Table(object name)
        {
            Name = (string)name;
            Columns = new Hashtable();
        }
        public string Name { get; set; }
        public Hashtable Columns { get; private set; }
        public bool add = false, mod = false;
        public override bool Equals(object obj)
        {
            var TBL = obj as Table;
            if (TBL == null)
                return !(add = true);
            foreach (Column COL in Columns.Values)
                if (!COL.Equals(TBL.Columns[COL.Name]))
                    mod = true;
            return Name == TBL.Name && Columns.Count == TBL.Columns.Count && !mod;
        }
    }
    class Program
    {
        static string Str1 = @"Server=.\ABU;Database=SM1;Integrated Security=SSPI;";
        static string Str2 = @"Server=.\ABU;Database=SM2;Integrated Security=SSPI;";
        static void Main(string[] args)
        {
            var hash1 = Loading(Str1);
            var hash2 = Loading(Str2);
            Console.WriteLine("Comparing...");
            Console.WriteLine("Source:");
            foreach (Table table in hash1.Values)
                if (!table.Equals(hash2[table.Name]))
                    Trace(table);
            Console.WriteLine("Destination:");
            foreach (Table table in hash2.Values)
                if (!table.Equals(hash1[table.Name]))
                    Trace(table);
        }
        static void Trace(Table table)
        {
            if (table.add)
                Console.WriteLine("Add: " + table.Name);
            if (table.mod)
            {
                Console.WriteLine("Mod: " + table.Name);
                foreach (Column column in table.Columns.Values)
                {
                    if (column.add)
                        Console.WriteLine("\tAdd: " + column);
                    if (column.mod)
                    {
                        Console.WriteLine("\tMod: " + column);
                        Console.WriteLine("\tObj: " + column.OBJ);
                    }
                    if (column.Foreign != null)
                    {
                        if (column.Foreign.add)
                            Console.WriteLine("\t\tAdd: " + column.Foreign);
                        if (column.Foreign.mod)
                        {
                            Console.WriteLine("\t\tMod: " + column.Foreign);
                            Console.WriteLine("\t\tObj: " + column.Foreign.OBJ);
                        }
                    }
                }
            }
        }
        static Hashtable Loading(string str)
        {
            var hashtable = new Hashtable();
            using (var sql = new SqlConnection(str))
            {
                sql.Open();
                foreach (DataRow tbl in sql.GetSchema("TABLES").Rows)
                {
                    var table = new Table(tbl["TABLE_NAME"]);
                    var cmd = sql.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SP_COLUMNS " + table.Name;
                    using (var col = cmd.ExecuteReader())
                        while (col.Read())
                            table.Columns[col[3]] = new Column(col["COLUMN_NAME"], col["TYPE_NAME"], col["LENGTH"], col["NULLABLE"]);
                    hashtable[table.Name] = table;
                    Console.Write(table.Name + ",");
                }
                foreach (Table table in hashtable.Values)
                {
                    var cmd = sql.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SP_FKEYS " + table.Name;
                    using (var row = cmd.ExecuteReader())
                        while (row.Read())
                            ((Column)((Table)hashtable[row["FKTABLE_NAME"]]).Columns[row["FKCOLUMN_NAME"]]).Foreign = new Foreign(row["FK_NAME"], table, table.Columns[row["PKCOLUMN_NAME"]]);
                    Console.Write(table.Name + ",");
                }
            }
            Console.WriteLine();
            return hashtable;
        }
    }
}
