﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.Models
{
    public class UserRole
    {
        public UserRole(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

    }
}
