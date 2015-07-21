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

namespace URLShortner
{
    public partial class Form2 : Form
    {
        public string conString;
        public Form2()
        {
            InitializeComponent();
        }


        private void buttonAddtoDatabase_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("insert into words values (@p1)", con);
            cmd.Parameters.AddWithValue("@p1", textBoxWord.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");
                fillGrid();
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        public void fillGrid()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select * from Words", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = dr;
                dataGridView1.DataSource = source;
                
            }
            catch(SqlException f)
            {
                MessageBox.Show(f.Message);

            }
        }
    }
}
