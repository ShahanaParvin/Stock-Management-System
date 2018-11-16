using System;
using System.Data;
using System.Windows.Forms;
using StockManagementFormUI.BLL;
using StockManagementFormUI.Model;

namespace StockManagementFormUI
{
    public partial class SalesBetweenTwoDatesInfoApp : Form
    {
        public SalesBetweenTwoDatesInfoApp()
        {
            InitializeComponent();
        }
        Person person = new Person();
        Manager _manager = new Manager();
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            person.FromDateTimePicker =Convert.ToDateTime(dateTimePicker1.Text);
            person.ToDateTimePicker = Convert.ToDateTime(dateTimePicker2.Text);
            DataTable dt = new DataTable();
            dt = _manager.query(person);
            SaleDataGridView.DataSource = dt;
        }
    }
}
