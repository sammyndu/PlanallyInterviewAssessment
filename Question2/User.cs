using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    public class User
    {

        private static List<string> Users { get; set; } = new List<string>();

        public void Add(string username)
        {
            
            Users.Add(username);
        }

        public int GetUsersCount()
        {
            return Users.Count;
        }
    }
}
