using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace courseWork
{
    public partial class Accounting : Form
    {

        SqlConnection sqlconnection = null;
        private SqlDataAdapter adapter = null;  
        private DataTable table = null;
        public Accounting()
        {
            InitializeComponent();
        }
        
        private void Accounting_Load(object sender, EventArgs e) 
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Shipping". При необходимости она может быть перемещена или удалена.
            // this.shippingTableAdapter.Fill(this.dataSet.Shipping);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Shipping". При необходимости она может быть перемещена или удалена.
            // this.shippingTableAdapter.Fill(this.dataSet.Shipping);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Dispatcher". При необходимости она может быть перемещена или удалена.
            this.dispatcherTableAdapter.Fill(this.dataSet.Dispatcher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Sold_tickets". При необходимости она может быть перемещена или удалена.
            // this.sold_ticketsTableAdapter.Fill(this.dataSet.Sold_tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Unsold_tickets". При необходимости она может быть перемещена или удалена.
            // this.unsold_ticketsTableAdapter.Fill(this.dataSet.Unsold_tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Route". При необходимости она может быть перемещена или удалена.
            // this.routeTableAdapter.Fill(this.dataSet.Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Bus". При необходимости она может быть перемещена или удалена.
            // this.busTableAdapter.Fill(this.dataSet.Bus);
        }

        private void textBox_filter_dispatchers(object sender, EventArgs e) 
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Dispatcher", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("name like '{0}%'", textBox1.Text);
        }
        private void comboBox_filter_dispatchers(object sender, EventArgs e) 
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Dispatcher", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("id <= 5");
                    break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("id >= 5 AND id <= 8");
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("id > 8");
                    break;
                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("");
                    break;
            }
        }
        private void view_shipping(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Shipping", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView7.DataSource = table;
        }
        public void view_other(object sender, EventArgs e) //view1
        {
            Accounting2 accounting2 = new Accounting2();
            accounting2.Show();
            Hide();
        }
        private void view_sold_tickets(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT place, name, price FROM Sold_tickets", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }

        public void view_unsold_tickets(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT place, price FROM Unsold_tickets", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView4.DataSource = table;

        }
    
        private void view_routes(object sender, EventArgs e) 
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Route", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView5.DataSource = table;
        }

        private void add_shipping(object sender, EventArgs e)
        {
            Shipping shipping = new Shipping();
            shipping.Show();
        }

        private void delete_shipping(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();

            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView7.SelectedRows)
                {
                    dataGridView7.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void save_shipping(object sender, EventArgs e) 
        {
            try
            {
                sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
                sqlconnection.Open();
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                adapter.Update(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        private void addShippingWithToolStripMenu(object sender, EventArgs e) 
        {
            Shipping shipping = new Shipping();
            shipping.Show();
        }

        private void deleteShippingWithToolStripMenu(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();

            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView7.SelectedRows)
                {
                    dataGridView7.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Successfully deleted!");
            }
        }
    }
}

