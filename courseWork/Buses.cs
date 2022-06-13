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
    public partial class Buses : Form
    {
        SqlConnection sqlconnection = null;
        public Buses()
        {
            InitializeComponent();
        }


        private void Buses_Load(object sender, EventArgs e)
        {

        }

        private void add_bus(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Bus] (id, number, model, plate_number, number_of_seats, passenger_names, kids_name, pets_name) " +
                "VALUES (@id, @number, @model, @plate_number, @number_of_seats, @passenger_names, @kids_name, @pets_name)", sqlconnection);

            command.Parameters.AddWithValue("id", textBox1.Text);
            command.Parameters.AddWithValue("number", textBox2.Text);
            command.Parameters.AddWithValue("model", textBox3.Text);
            command.Parameters.AddWithValue("plate_number", textBox4.Text);
            command.Parameters.AddWithValue("number_of_seats", textBox5.Text);
            command.Parameters.AddWithValue("passenger_names", textBox6.Text);
            command.Parameters.AddWithValue("kids_name", textBox7.Text);
            command.Parameters.AddWithValue("pets_name", textBox8.Text);

            command.ExecuteNonQuery();
        }
    }
}
