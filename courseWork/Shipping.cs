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
    public partial class Shipping : Form
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
        public Shipping()
        {
            InitializeComponent();
        }

        private void add_shipping(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Shipping] (id, number, id_route, id_sold_tickets, id_unsold_tickets, id_dispatcher, id_bus, id_drver) " +
                "VALUES (@id, @number, @id_route, @id_sold_tickets, @id_unsold_tickets, @id_dispatcher, @id_bus, @id_drver)", sqlconnection);

            command.Parameters.AddWithValue("id", textBox1.Text);
            command.Parameters.AddWithValue("number", textBox2.Text);
            command.Parameters.AddWithValue("id_route", textBox3.Text);
            command.Parameters.AddWithValue("id_sold_tickets", textBox4.Text);
            command.Parameters.AddWithValue("id_unsold_tickets", textBox5.Text);
            command.Parameters.AddWithValue("id_dispatcher", textBox6.Text);
            command.Parameters.AddWithValue("id_bus", textBox7.Text);
            command.Parameters.AddWithValue("id_drver", textBox8.Text);

            command.ExecuteNonQuery();
        }
    }
}
