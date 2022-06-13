using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace courseWork
{
    public partial class Accounting2 : Form
    {
        SqlConnection sqlconnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public Accounting2()
        {
            InitializeComponent();

        }
        private void Accounting2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Shipping". При необходимости она может быть перемещена или удалена.
            // this.shippingTableAdapter.Fill(this.dataSet.Shipping);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Kids". При необходимости она может быть перемещена или удалена.
            // this.kidsTableAdapter.Fill(this.dataSet.Kids);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Passengers". При необходимости она может быть перемещена или удалена.
            // this.passengersTableAdapter.Fill(this.dataSet.Passengers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Pets". При необходимости она может быть перемещена или удалена.
            // this.petsTableAdapter.Fill(this.dataSet.Pets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Dispatcher". При необходимости она может быть перемещена или удалена.
            // this.dispatcherTableAdapter.Fill(this.dataSet.Dispatcher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Bus". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Driver". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Sold_tickets". При необходимости она может быть перемещена или удалена.
            // this.sold_ticketsTableAdapter.Fill(this.dataSet.Sold_tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Route". При необходимости она может быть перемещена или удалена.
            // this.routeTableAdapter.Fill(this.dataSet.Route);

        }
        private void view_kids(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT id, name FROM Kids", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.Show();
            Hide();
        }

        private void comboBox_filter_passengers(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Passengers", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView4.DataSource = table;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = String.Format("id <= 5");
                    break;
                case 1:
                    (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = String.Format("id >= 5 AND id <= 8");
                    break;
                case 2:
                    (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = String.Format("id > 8");
                    break;
                case 3:
                    (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = String.Format("");
                    break;
            }
        }

        private void view_drivers(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Driver", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }

        private void view_buses(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Bus", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox_filter_passengers(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Passengers", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView4.DataSource = table;
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = String.Format("kids_name like '{0}%'", textBox2.Text);
        }

        private void textBox_filter_drivers(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Driver", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView3.DataSource = table;
            (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = String.Format("name like '{0}%'", textBox3.Text);
        }

        private void comboBox_filter_drivers(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Driver", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView3.DataSource = table;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = String.Format("id <= 5");
                    break;
                case 1:
                    (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = String.Format("id >= 5 AND id <= 8");
                    break;
                case 2:
                    (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = String.Format("id > 8");
                    break;
                case 3:
                    (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = String.Format("");
                    break;
            }
        }

        private void add_kids(object sender, EventArgs e)
        {
            Kids form4 = new Kids();
            form4.Show();
        }
        public void My_Execute_Non_Query(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = sqlConnection.CreateCommand();
            myCommand.CommandText = sql;
            myCommand.ExecuteNonQuery();
        }

        private void delete_kids(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();

            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    dataGridView2.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Successfully deleted!");
            }

        }

        private void view_pets(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Pets", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView5.DataSource = table;
        }

        private void add_pets(object sender, EventArgs e)
        {
            Pets pets = new Pets();
            pets.Show();
        }

        private void view_passengers(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Passengers", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView4.DataSource = table;
        }
        private void add_passenger(object sender, EventArgs e)
        {
            Passengers passengers = new Passengers();
            passengers.Show();
        }

        private void add_driver(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.Show();
        }

        private void add_bus(object sender, EventArgs e)
        {
            Buses buses = new Buses();
            buses.Show();
        }

        private void delete_passenger(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();

            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
                {
                    dataGridView4.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void save_passengers(object sender, EventArgs e) 
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


        private void save_drivers(object sender, EventArgs e)
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

        private void save_buses(object sender, EventArgs e)
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

        private void save_kids(object sender, EventArgs e)
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

        private void save_pets(object sender, EventArgs e)
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

        private void delete_bus(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();

            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void delete_pets(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();

            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView5.SelectedRows)
                {
                    dataGridView5.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void delete_driver(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();

            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
                {
                    dataGridView3.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Successfully deleted!");
            }
        }

        private void back(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.Show();
            Hide();
        }

    }
}

