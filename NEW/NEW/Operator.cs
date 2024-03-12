using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW
{
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Operator_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MAZAY24\\MSSQLSERVER01;Initial Catalog=Lab;Integrated Security=True;Encrypt=False");
            conn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM INFO", conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "INFO");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "INFO";
            conn.Close();
        }
    }
}
