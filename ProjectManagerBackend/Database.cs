using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend
{
    public class Database
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();

    }
}
