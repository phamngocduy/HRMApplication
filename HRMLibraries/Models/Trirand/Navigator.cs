using System;

namespace HRM.Webpages.Models.Trirand
{
    public class Navigator
    {
        public Navigator(string id, bool edit = false, bool add = false, bool delete = false)
        {
            this.id = id;
            this.edit = edit;
            this.add = add;
            this.del = delete;
        }

        public string id { get; private set; }
        public bool edit { get; private set; }
        public bool add { get; private set; }
        public bool del { get; private set; }
    }
}
