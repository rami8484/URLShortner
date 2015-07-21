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
    public partial class Form1 : Form
    {
        string conString;
        public Form1()
        {
            InitializeComponent();
            conString = "data source = WISSACZH\\RAMI;database = words; integrated security = true;";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenAddToDatabase_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.conString = conString;
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonShortenURL_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select * from words", con);
            SqlDataReader dr;
            try
            {
                con.Open();
                string sourceURLToBeModified = textBoxSourceURL.Text;
                dr =   cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (sourceURLToBeModified.Contains(dr["Word"].ToString()))
                    {
                        sourceURLToBeModified = sourceURLToBeModified.Replace(dr["Word"].ToString(), dr["ID"].ToString() + "-");
                    }
                }
                textBoxURLAfterShortening.Text = sourceURLToBeModified;
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

        private void buttonGetSourceURL_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select * from words", con);
            SqlDataReader dr;
            try
            {
                con.Open();
                string URLToBeModified = textBoxURLAfterShortening.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (URLToBeModified.Contains(dr["ID"].ToString() + "-"))
                    {
                        URLToBeModified = URLToBeModified.Replace(dr["ID"].ToString() + "-", dr["word"].ToString() );
                    }
                }
                textBoxSourceURL.Text = URLToBeModified;
            }
            catch (SqlException f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
