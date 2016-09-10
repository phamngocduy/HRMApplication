using System;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace HRM.Webpages.Models.Trirand
{
    public class Grid
    {
        public Grid()
        {
            Columns = new Column[0];
            Properties = new Hashtable();
        }

        public Hashtable Properties { get; private set; }

        public Column[] Columns { get; set; }
        public string Caption { set { Properties["caption"] = value; } }
        public object Width { set { Properties["width"] = value; } }
        public object Height { set { Properties["height"] = value; } }
        public string Pager { set { Properties["pager"] = "#" + value; } }
        public int RowNum { set { Properties["rowNum"] = value; } }
        public int[] RowList { set { Properties["rowList"] = value; } }
        public bool MultiSelect { set { Properties["multiselect"] = value; } }
        public int[] Selected { get; set; }

        public string onSelectRow { get; set; }
        public string loadComplete { get; set; }
        public Navigator navGrid { get; set; }

        public string GetColumnNames()
        {
            var text = new StringBuilder();
            foreach (var column in Columns)
                text.Append("\"").Append(column).Append("\", ");
            return text.ToString();
        }

        public string GetColumnModel(int index)
        {
            return GetColumnModel(Columns[index]);
        }
        public string GetColumnModel(Column column)
        {
            var text = new StringBuilder();
            text.Append("{ ");
            foreach (var property in column.Properties.Keys)
                text.Append(helper(property.ToString(), column.Properties[property])).Append(", ");
            text.Append("},");
            return text.ToString();
        }

        private string format(object value, char open = '"', char close = '"')
        {
            if (value is int || value is Boolean)
                return value.ToString().ToLower();
            if (value is Alignment || value is SortTypes)
                return String.Format("{0}{1}{2}", open, value.ToString().ToLower(), close);
            return String.Format("{0}{1}{2}", open, value, close);
        }
        private string helper(string name, object value, char open = '"', char close = '"')
        {
            return String.Format("{0}:{1}", name, format(value, open, close));
        }

        public string GetPropertyValues()
        {
            var text = new StringBuilder();
            foreach (var property in Properties.Keys)
            {
                if (property.Equals("rowList"))
                    text.Append(helper(property.ToString(),
                    String.Join(",", (Properties[property] as int[]).Select(i => i.ToString()).ToArray()), '[', ']')).Append(",\n");
                else text.Append(helper(property.ToString(), Properties[property])).Append(",\n");
            }
            return text.ToString();
        }

        public string GetNavigatorValues()
        {
            return navGrid == null ? "" :
            String.Format(@".navGrid(""#{0}"", {{{1}}})", navGrid.id,
            String.Format(@"edit:{0}, add:{1}, del:{2}", navGrid.edit, navGrid.add, navGrid.del).ToLower());
        }

        public string GetEventHandlers(string id)
        {
            var text = new StringBuilder();
            if (!String.IsNullOrEmpty(onSelectRow))
                text.AppendLine(@"onSelectRow: function(id) {")
                    .Append("\t").AppendFormat(@"{0}($(""#{1}"").getRowData(id));", onSelectRow, id).AppendLine()
                    .AppendLine(@"},");
            if (!String.IsNullOrEmpty(loadComplete))
                text.AppendLine(@"loadComplete: function(data) {")
                    .Append("\t").AppendFormat(@"{0}();", loadComplete).AppendLine()
                    .AppendLine(@"},");
            return text.ToString();
        }
    }
}
