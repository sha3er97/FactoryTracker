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

        public DataTable GetAdministrators()
        {
            string query = "select name,id from Administrator ;";
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

        public DataTable getdepdetails(int id)
        {
            String Query = "Select * from Sub_Department where id=" + id + ";";
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

        public DataTable SelectProductionMachinesIcompanies(int id)
        {
            string query = "select maintenance_company from  Maintenance_Companies m,Production_Machines p where id = " + id + "and p.maintenance_company=m.id";
            return dbMan.ExecuteReader(query);

        }

        public DataTable SelectUtilitiesMachinescompanies(int id)
        {
            string query = "select * from Maintenance_Companies m,Utilities_Machines u where u.id = " + id + "and u.maintenance_company=m.id";
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

        public int InsertOperates(int operator_id, int utility_machine_id, int production_machine_id)
        {
            string Query = "insert into Operates (operator_id,utility_machine_id,production_machine_id) values(" + operator_id + " ," + utility_machine_id + "," + production_machine_id + " ) ;";
            return dbMan.ExecuteNonQuery(Query);
        }

        public int UpdateOperates(int id, int pmid)
        {
            string query = "update Operates set production_machine_id =" + pmid + " where =" + id;
            return dbMan.ExecuteNonQuery(query);
        }

        public int Getmaxidofadmin()
        //id of admin
        {
            String Query = "select MAX(id) from Administrator ;";
            return (int)dbMan.ExecuteScalar(Query);
        }

        public int InsertCompany(String name, String email, String add, String repname, String repemail, int rep_con_no)
        {
            String Query = "insert into Maintenance_Companies (name,e_mail,address,representative_name,representative_email,repre_contact_number) values ('ahmed','ahmed','ahmed','ahmed','ahmed',0);";
            return dbMan.ExecuteNonQuery(Query);
        }

        public int NewDepartment(string name, int cat, int buNo, int partNo, int manID)
        {
            String Query = "insert into Sub_Department (name,category,building_no,partition_no,manager_id) values ('" + name + "' ," + cat + " , " + buNo + " , " + partNo + " , " + manID + " ;";
            return dbMan.ExecuteNonQuery(Query);
        }

        public DataTable getAdminDetails(string name)
        {
            string query = "select * from Administrator where name = '" + name + "' ;";
            return dbMan.ExecuteReader(query);

        }

        public int DeleteAdmin(string name)
        {
            string query = "DELETE FROM Administrator WHERE name='" + name + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int getidofutilitymachinecom(int id)
        {
            string query = "SELECT maintenance_company from Utilities_Machines where id = " + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null)
                return (int)p;
            else return -1;

        }

        public int getidofproductionmachinecom(int id)
        {
            string query = "SELECT maintenance_company from Production_Machines where id = " + id;
            object p = dbMan.ExecuteScalar(query);
            if (p != null)
                return (int)p;
            else return -1;

        }

        public int DeleteCompany(int id)
        {
            string query = "DELETE FROM Maintainance_Companies WHERE id=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetCardsSent(int id, int type)
        {
            string query = "select * from Stop_Go_Cards where reported_by=" + id + "and type=" + type;
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetCardsReceived(int id, int type)
        {
            string query = "select id,observation,comment,date from Stop_Go_Cards,Cards_To_Admin where id=card_id and admin_id=" + id + "and type=" + type;
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetNamesOfOperators(int dep)
        {
            String Query = "select name,id from Operator where works_in=" + dep;
            return dbMan.ExecuteReader(Query);
        }
        public DataTable getDetailsOperatorByID(int id)
        {
            string query = "select * from Operator where id=" + id;
            return dbMan.ExecuteReader(query);
        }
        public int DeleteOperator(int id)
        {
            string query = "delete from Operator where id= " + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetNotesSentOperaor(int id)
        {
            string query = "select * from Notes_FYAs where from_operator=" + id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetNotesSentAdmin(int id)
        {
            string query = "select * from Notes_FYAs where from_administrator=" + id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetNotesReceivedOperator(int id)
        {
            string query = "select id,[content],from Notes_FYAs n,Notes_To_Employee t where t.id=n.id and t.operator_id=" + id;
            return dbMan.ExecuteReader(query);
        }
        public string getisreceived(int note)
        {
            int result = 2;
            string query = "select is_received from Notes_FYAs where id=" + note;
            object p = dbMan.ExecuteScalar(query);
            if (p != null)
            {
                result = (int)p;
                if (result == 0) return "Seen";
                else return "Not Yet";
            }
            else return " ";
        }
        public string getFrom(int note)
        {
            int result = -1;
            string query = "select from_administrator from Notes_FYAs where id=" + note;
            object p = dbMan.ExecuteScalar(query);
            if (p != null)
            {
                result = (int)p;
                if (result != 0) return getNameAdminByID(result);
                else
                {
                    query = "select from_operator from Notes_FYAs where id=" + note;
                    p = dbMan.ExecuteScalar(query);
                    if (p == null) return " ";
                    return getNameOperatorByID((int)p);
                }
            }
            else return " ";
        }
        public DataTable GetNotesReceivedAdmin(int id)
        {
            string query = "select id,[content],from Notes_FYAs n,Notes_To_Employee t where t.id=n.id and t.administrator_id=" + id;
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
