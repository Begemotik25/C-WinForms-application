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
    public partial class Pets : Form
    {
        SqlConnection sqlconnection = null;
        public Pets()
        {
            InitializeComponent();
        }

        private void add_pets(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Pets] (id, name) VALUES (@id, @name)", sqlconnection);

            command.Parameters.AddWithValue("id", textBox1.Text);
            command.Parameters.AddWithValue("name", textBox2.Text);

            command.ExecuteNonQuery();
            sqlconnection.Close();
        }
    }
}
