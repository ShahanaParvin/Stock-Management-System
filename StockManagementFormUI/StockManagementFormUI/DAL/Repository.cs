using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
using StockManagementInfoApp;
using System.Drawing;
using StockManagementFormUI.Model;


namespace StockManagementInfoApp.DAL
{
   public class Repository
    {
       static string _connectionString = @"server=DESKTOP-412B1P8\SQLEXPRESS;Database=StockManagement;Integrated security=true";
        static SqlConnection _con = new SqlConnection(_connectionString);
        public bool Add(Person person)
        {
            string query = @"INSERT INTO Categories Values('" + person.CategoryName + "')";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            bool isAdded = command.ExecuteNonQuery() > 0;
            _con.Close();
            return isAdded;
            
        }

       

        public bool companyAdd(Person person)
        {
            string query = @"INSERT INTO Companies Values('" + person.CompanyName + "')";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            bool isAdded = command.ExecuteNonQuery() > 0;
            _con.Close();
            return isAdded;
        }

        public bool update(Person person)
        {
            string query = @"Update Categories SET Name='" + person.CategoryName + "'WHERE Id='" + person.Id + "'";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            bool isUpdate = command.ExecuteNonQuery() > 0;
            _con.Close();
            return isUpdate;
        }

        public bool Companyupdate(Person person)
        {
            string query = @"Update Companies SET Name='" + person.CompanyName + "'WHERE Id='" + person.Id + "'";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            bool isUpdate = command.ExecuteNonQuery() > 0;
            _con.Close();
            return isUpdate;
        }


        public DataTable query(Person person)
        {

            string connectionString = @"server=DESKTOP-412B1P8\SQLEXPRESS;Database=StockManagement;Integrated security=true";
            SqlConnection con = new SqlConnection(connectionString);
            string query = @"Select i.Name,s.Quantity From StockInOut s
            Inner Join Items i On i.Id=s.ItemId
            WHERE Date Between '" + person.FromDateTimePicker + "' AND '" + person.ToDateTimePicker + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);

            con.Close();
            return dt;
        }
    }
}
