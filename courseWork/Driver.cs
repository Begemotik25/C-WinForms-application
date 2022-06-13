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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }
        private void Driver_Load(object sender, EventArgs e)
        {

        }

        private void add_driver(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Driver] (id, name, dob, passport) VALUES (@id, @name, @dob, @passport)", sqlconnection);

            command.Parameters.AddWithValue("id", textBox1.Text);
            command.Parameters.AddWithValue("name", textBox2.Text);
            command.Parameters.AddWithValue("dob", textBox3.Text);
            command.Parameters.AddWithValue("passport", textBox4.Text);

            command.ExecuteNonQuery();
        }
    }
}
