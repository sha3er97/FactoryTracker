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
                if (p != null) return (int)p;
                return -1;

            }
        }
        public int getIDOperator(string user, string pass)
        {
            string query = "select id from Operator where username=' " + user + " ' and password=' " + pass + " ';";
            object p = dbMan.ExecuteScalar(query);
            if (p != null) return (int)p;
            else return -1;
        }
        public int getIDAdminstrator(string user, string pass)
        {
            string query = "select id from Administrator where username=' " + user + " ' and password=' " + pass + " ';";
            object p = dbMan.ExecuteScalar(query);
            if (p != null) return (int)p;
            else return -1;
        }
        public int getDepByID(int id)
        {
            string query = "SELECT works_in from Operator where id = " + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null)
                return (int)p;
            else return -1;

        }
        public DataTable GetGaugesByID(int id)
        {
            int dep = getDepByID(id);
            if (dep != -1)
            {
                string query = "select no from Safety_Gauges where id=" + dep;
                return dbMan.ExecuteReader(query);
            }
            else
                return null;

        }
        public int UpdateGauge(int reading, int id, int no)
        {
            string query = "update Safety_Gauges set current_reading= " + reading + " where id=" + id + "and no=" + no;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetGauges(int id, string type)
        {
            string query = "select * from Safety_Gauges where department_id=" + id + "and type='" + type + "'";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteGauge(int id, int no)
        {
            string query = "delete from Safety_Gauges where id= " + id + " and no=" + id + "and no=" + no;
            return dbMan.ExecuteNonQuery(query);
        }

        public int getCategory(int id)
        {
            string query = "SELECT category from Sub_Department where id = " + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null)
                return (int)p;
            else return -1;

        }

        public DataTable GetProblemsUtility(int id, string cat)
        {
            string query = "select no,description,cause,solution,supervised_by from Documented_Problems where utility_machine_id=" + id + "and category='" + cat + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetProblemsProduction(int id, string cat)
        {
            string query = "select no,description,cause,solution,supervised_by from Documented_Problems where production_machine_id=" + id + "and category='" + cat + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDeparments()
        {
            String Query = "Select id,name from Sub_Department";
            return dbMan.ExecuteReader(Query);
        }

        public int NewAdministrator(string name, String user, String email)
        {
            String Query = "insert into Administrator (name,username,e_mail) values('" + name + "' ,'" + user + "' , '" + email + "' ;";
            return dbMan.ExecuteNonQuery(Query);
        }

        //Add Operator
        public int NewOperator(string name, String user, String email, string dep, int ch)
        {
            string Query;
            if (ch == 1)
                Query = "insert into Operator (name,username,e_mail) values('" + name + "' ,'" + user + "' , '" + email + "' , '" + dep + "' , 1 ) ;";
            else
                Query = "insert into Operator (name,username,e_mail) values('" + name + "' ,'" + user + "' , '" + email + "' , " + dep + ") ;";
            return dbMan.ExecuteNonQuery(Query);
        }

        public DataTable SelectUtilitiesMachinesInDepartment(int id)
        {
            string query = "select name from Utilities_Machines where included_in = " + id;
            return dbMan.ExecuteReader(query);

        }

        public DataTable SelectProductionMachinesInDepartment(int id)
        {
            string query = "select name from Production_Machines where included_in = " + id;
            return dbMan.ExecuteReader(query);

        }

        public string getNameOperatorByID(int id)
        {
            string query = "select name from Operator where id=" + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null) return (string)p;
            else return null;
        }
        public string getNameAdminByID(int id)
        {
            string query = "select name from Administrator where id=" + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null) return (string)p;
            else return null;
        }
        public string getDepAdminByID(int id)
        {
            string query = "select name from Administrator,Sub_Department where manager_id=id and id=" + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null) return (string)p;
            else return null;
        }
        public string getDepOperatorByID(int id)
        {
            string query = "select name from Operator o,Sub_Department s where o.works_in=s.id and o.id=" + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null) return (string)p;
            else return null;
        }
        public int UpdateProfileOperator(string user, string pass, string email, int id)
        {
            string query = "update Operator set username= " + user + " where id=" + id;
            dbMan.ExecuteNonQuery(query);
            query = "update Operator set password= " + pass + " where id=" + id;
            dbMan.ExecuteNonQuery(query);
            query = "update Operator set e_mail= " + email + " where id=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateProfileAdmin(string user, string pass, string email, int id)
        {
            string query = "update Administrator set username= " + user + " where id=" + id;
            dbMan.ExecuteNonQuery(query);
            query = "update Administrator set password= " + pass + " where id=" + id;
            dbMan.ExecuteNonQuery(query);
            query = "update Administrator set e_mail= " + email + " where id=" + id;
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatedepadmin(int manid, string name)
        {
            string query = "update Sub_Department set manager_id= " + manid + " where name= '" + name + "' ";
            return dbMan.ExecuteNonQuery(query);
        }




        public int Getmaxidofadmin()
        //id of admin
        {
            String Query = "select MAX(id) from Administrator ;";
            return (int)dbMan.ExecuteScalar(Query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
