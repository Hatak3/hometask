using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.HomeWork
{
    public class Account
    {
        public List<User> user = new List<User>();
        public void Register(User use) { user.Add(use); }
    }
}