using System;
using System.Collections;

namespace HRM.Webpages.Models.Trirand
{
    public enum Alignment { Left, Center, Right }
    public enum SortTypes { String, Int, Float, Date }

    public class Column
    {
        public Column(string display)
        {
            Display = display;
            Properties = new Hashtable();
        }

        public Hashtable Properties { get; private set; }

        public string Name { set { Properties["name"] = value; } }
        public string Format { set { Properties["format"] = value; } }
        public int Width { set { Properties["width"] = value; } }
        public Alignment Align { set { Properties["align"] = value; } }
        public bool Sortable { set { Properties["sortable"] = value; } }
        public SortTypes SortType { set { Properties["sorttype"] = value; } }
        public bool Hidden { set { Properties["hidden"] = value; } }

        private string Display = "";
        public override string ToString()
        {
            return Display;
        }
    }
}
