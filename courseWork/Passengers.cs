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
    public partial class Passengers : Form
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");

        public Passengers()
        {
            InitializeComponent();
        }

        private void add_passenger(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Passengers] (id, name, kids_name, pets_name) VALUES (@id, @name, @kids_name, @pets_name)", sqlconnection);

            command.Parameters.AddWithValue("id", textBox1.Text);
            command.Parameters.AddWithValue("name", textBox4.Text);
            command.Parameters.AddWithValue("kids_name", textBox2.Text);
            command.Parameters.AddWithValue("pets_name", textBox3.Text);

            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accounting2 accounting2 = new Accounting2();
            accounting2.Show();
            Hide();
        }
    }
}
