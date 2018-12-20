using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Tracker
{
    class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int CheckPassword_Basic(string username, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT prev from Operator where username = '" + username + "' and password='" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p != null) return (int)p;
            else
            {
                query = "SELECT prev from Administrator where username= '" + username + "' and password='" + password + "';";
                p = dbMan.ExecuteScalar(query);
                if(p != null) return (int)p;
                return -1;
            
            }
            }


            public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
