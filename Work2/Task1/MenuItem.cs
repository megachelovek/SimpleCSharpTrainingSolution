using System;
using System.Collections.Generic;
using System.Text;

namespace Work2
{
    class MenuItem
    {
        private int position;

        private string name;

        private string[] users;

        public MenuItem(int position, string name, string[] users)
        {
            this.position = position;
            this.name = name;
            this.users = users;
        }

        public int Position { get => position; set => position = value; }
        public string Name { get => name; set => name = value; }
        public string[] Users { get => users; set => users = value; }
    }
}
