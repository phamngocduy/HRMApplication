using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.Mvc.Html;
using System.Globalization;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.Specialized;

using HRM.Databases.Models;
namespace HRM.Webpages.Helpers
{
    public static class DataTableExt
    {
        public static DataTable SqlQuery(this HRMDBEntities db, string sql, params object[] parameters)
        {
            return db.Database.SqlQuery(sql, parameters);
        }
        public static DataTable SqlQuery(this HRMDB0Entities db, string sql, params object[] parameters)
        {
            return db.Database.SqlQuery(sql, parameters);
        }
        public static DataTable SqlQuery(this Database db, string sql, params object[] parameters)
        {
            using (var connection = new SqlConnection(db.Connection.ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                int i = 0;
                connection.Open();
                parameters.ToList().ForEach(p =>
                    command.Parameters.Add(new SqlParameter(String.Format("p{0}", i++), p)));
                using (var reader = command.ExecuteReader())
                {
                    var table = new DataTable();
                    table.Load(reader);
                    return table;
                }
            }
        }

        public static string SqlCreate(this HRMDBEntities db, string name, NameValueCollection form)
        {
            return db.Database.SqlCreate(name, form);
        }
        public static string SqlCreate(this HRMDB0Entities db, string name, NameValueCollection form)
        {
            return db.Database.SqlCreate(name, form);
        }
        public static string SqlCreate(this Database db, string name, NameValueCollection form)
        {
            using (var connection = new SqlConnection(db.Connection.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "select top 0 * from " + name;
                var table = new DataTable();
                using (var reader = command.ExecuteReader())
                    table.Load(reader);
                var @params = new NameValueCollection();
                foreach (string key in form.Keys)
                    if (table.Columns.Contains(key))
                        @params.Add(key, format(table.Columns[key], form[key]));

                var fields = new List<string>();
                var values = new List<string>();
                foreach (var key in @params.AllKeys.Where(k => k != "id"))
                {
                    fields.Add(key);
                    if (@params[key] != null)
                        values.Add(String.Format("N'{0}'", @params[key]));
                    else values.Add("null");
                }
                command.CommandText = String.Format("insert into {0}({1}) values({2})", name,
                    String.Join(",", fields), String.Join(",", values));
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return null;
        }

        public static string SqlUpdate(this HRMDBEntities db, string name, NameValueCollection form)
        {
            return db.Database.SqlUpdate(name, form);
        }
        public static string SqlUpdate(this HRMDB0Entities db, string name, NameValueCollection form)
        {
            return db.Database.SqlUpdate(name, form);
        }
        public static string SqlUpdate(this Database db, string name, NameValueCollection form)
        {
            using (var connection = new SqlConnection(db.Connection.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "select top 0 * from " + name;
                var table = new DataTable();
                using (var reader = command.ExecuteReader())
                    table.Load(reader);
                var @params = new NameValueCollection();
                foreach (string key in form.Keys)
                    if (table.Columns.Contains(key))
                        @params.Add(key, format(table.Columns[key], form[key]));

                var attribs = new List<string>();
                foreach (var key in @params.AllKeys.Where(k => k != "id"))
                {
                    attribs.Add(String.Format("{0}={1}", key, @params[key] != null ?
                        String.Format("N'{0}'", @params[key]) :  "null"));
                }
                command.CommandText = String.Format("update {0} set {1} where id={2}", name,
                    String.Join(",", attribs), @params["id"]);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return null;
        }

        public static int SqlExecute(this HRMDBEntities db, string query, params object[] parameters)
        {
            return db.Database.SqlExecute(query, parameters);
        }
        public static int SqlExecute(this HRMDB0Entities db, string query, params object[] parameters)
        {
            return db.Database.SqlExecute(query, parameters);
        }
        public static int SqlExecute(this Database db, string query, params object[] parameters)
        {
            using (var connection = new SqlConnection(db.Connection.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                int i = 0;
                connection.Open();
                command.CommandText = query;
                parameters.ToList().ForEach(p =>
                    command.Parameters.Add(new SqlParameter(String.Format("p{0}", i++), p)));
                return command.ExecuteNonQuery();
            }
        }

        private static string format(DataColumn field, string value)
        {
            if (String.IsNullOrEmpty(value))
                return null;
            try
            {
                if (field.DataType.Equals(typeof(string)))
                    return value;
                if (field.DataType.Equals(typeof(int)))
                    return int.Parse(value).ToString();
                if (field.DataType.Equals(typeof(double)))
                    return double.Parse(value).ToString(CultureInfo.InvariantCulture);
                if (field.DataType.Equals(typeof(DateTime)))
                    return DateTime.Parse(value).ToString("yyyy-MM-dd");
                if (field.DataType.Equals(typeof(bool)))
                    return value.ToLower().StartsWith("true") ? "1" : "0";
            }
            catch (Exception e)
            {
                throw new Exception(String.Format("{0}: {1}", field.ColumnName, e.Message));
            }
            throw new NotImplementedException(field.ColumnName);
        }

        public static string SqlDelete(this HRMDBEntities db, string name, int id)
        {
            return db.Database.SqlDelete(name, id);
        }
        public static string SqlDelete(this HRMDB0Entities db, string name, int id)
        {
            return db.Database.SqlDelete(name, id);
        }
        public static string SqlDelete(this Database db, string name, int id)
        {
            using (var connection = new SqlConnection(db.Connection.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "delete from " + name + " where id=" + id;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return null;
        }

        public static IHtmlString Editor(this HtmlHelper html, DataRow model, DataColumn field)
        {
            var value = model != null ? model[field] : null;
            value = value is DBNull ? null : value;
            if (field.DataType.Equals(typeof(string)))
                return html.TextBox(field.ColumnName, value ?? "");
            if (field.DataType.Equals(typeof(int)))
                return html.TextBox(field.ColumnName, value ?? "", new { type = "number" });
            if (field.DataType.Equals(typeof(double)))
                return html.TextBox(field.ColumnName, value ?? "");
            if (field.DataType.Equals(typeof(DateTime)))
                return html.TextBox(field.ColumnName, value != null ? ((DateTime)value).ToShortDateString() : "", new { type = "date" });
            if (field.DataType.Equals(typeof(bool)))
                return html.CheckBox(field.ColumnName, value != null ? (bool)value : false);
            throw new NotImplementedException(field.ColumnName);
        }

        public static IHtmlString Display(this HtmlHelper html, DataRow model, DataColumn field)
        {
            var value = model != null ? model[field] : null;
            value = value is DBNull ? null : value;
            if (field.DataType.Equals(typeof(string)))
                return MvcHtmlString.Create((value ?? "").ToString());
            if (field.DataType.Equals(typeof(int)))
                return MvcHtmlString.Create((value ?? "").ToString());
            if (field.DataType.Equals(typeof(double)))
                return MvcHtmlString.Create((value ?? "").ToString());
            if (field.DataType.Equals(typeof(DateTime)))
                return MvcHtmlString.Create(value != null ? ((DateTime)value).ToShortDateString() : null);
            if (field.DataType.Equals(typeof(bool)))
                return html.CheckBox("check", value != null ? (bool)value : false, new { disabled = true });
            throw new NotImplementedException(field.ColumnName);
        }

        private static string root(string link, HtmlHelper html)
        {
            return link.Replace("~", html.Root());
        }
        public static IHtmlString Editor4A(this HtmlHelper html, string link, string text, string rand)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Add(this,'{1}')"">{2}</a>",
            root(link, html), rand, text));
        }
        public static IHtmlString Editor4C(this HtmlHelper html, string link)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Edit(this,true)"" style=""padding:0;text-decoration:blink"">
                <span title=""Add"" class=""ui-icon ui-icon-circle-plus"" style=""display:inline-block""></span>
            </a>", root(link, html)));
        }
        public static IHtmlString Editor4I(this HtmlHelper html, string link)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Edit(this)"" style=""padding:0;text-decoration:blink"">
                <span title=""Edit"" class=""ui-icon ui-icon-circle-plus"" style=""display:inline-block""></span>
            </a>", root(link, html)));
        }
        public static IHtmlString Editor4U(this HtmlHelper html, string link)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Edit(this)"" style=""padding:0;text-decoration:blink"">
                <span title=""Edit"" class=""ui-icon ui-icon-pencil"" style=""display:inline-block""></span>
            </a>", root(link, html)));
        }
        public static IHtmlString Editor4D(this HtmlHelper html, string link)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Delete(this)"" style=""padding:0;text-decoration:blink"">
                <span title=""Delete"" class=""ui-icon ui-icon-close"" style=""cursor:pointer;display:inline-block""></span>
            </a>", root(link, html)));
        }
        public static IHtmlString Link4C(this HtmlHelper html, string link, string text)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Edit(this,true)"" style=""padding:0;text-decoration:blink"">
            {1}</a>", root(link, html), text));
        }
        public static IHtmlString Link4U(this HtmlHelper html, string link, string text)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Edit(this)"" style=""padding:0;text-decoration:blink"">
            {1}</a>", root(link, html), text));
        }
        public static IHtmlString Link4D(this HtmlHelper html, string link, string text)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Delete(this)"" style=""padding:0;text-decoration:blink"">
            {1}</a>", root(link, html), text));
        }
        public static IHtmlString Link4S(this HtmlHelper html, string link, string text)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Action(this)"" style=""padding:0;text-decoration:blink"">
            {1}</a>", root(link, html), text));
        }
        public static IHtmlString Link4R(this HtmlHelper html, string link, string text)
        {
            return MvcHtmlString.Create(String.Format(@"
            <a href=""{0}"" onclick=""return Editor_Action(this,true)"" style=""padding:0;text-decoration:blink"">
            {1}</a>", root(link, html), text));
        }

        public static IEnumerable<DataRow> ToArray(this DataRowCollection rows)
        {
            foreach (DataRow row in rows) yield return row;
        }
    }
}
