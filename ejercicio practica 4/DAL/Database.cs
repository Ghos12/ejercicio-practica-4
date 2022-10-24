using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections;
using ejercicio_practica_4.Properties;
using System.Threading.Tasks;
using System.Configuration;

namespace ejercicio_practica_4.DAL
{
    public class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }

        public bool testConection()
        {
            SqlConnection Con = this.getConnection();
            Con.Open();
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
