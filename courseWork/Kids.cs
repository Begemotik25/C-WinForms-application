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
    public partial class Kids : Form
    {
        SqlConnection sqlconnection = null;
        public Kids()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void add_kids(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Kids] (id, name) VALUES (@id, @name)", sqlconnection);

            command.Parameters.AddWithValue("id", textBox4.Text);
            command.Parameters.AddWithValue("name", textBox2.Text);

            command.ExecuteNonQuery();
            sqlconnection.Close();
        }
    }
}
