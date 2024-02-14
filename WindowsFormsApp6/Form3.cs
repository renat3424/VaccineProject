using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string email = textBox1.Text;
                string pwd = textBox2.Text;
                Db db = new Db();
                DataTable table = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter();
                string query = "select * from hospital where h_email="+email+" and h_pwd="+pwd;
                MySqlCommand command = new MySqlCommand(query, db.GetConnection());
               
           
                adp.SelectCommand = command;
                adp.Fill(table);

                
                if (table.Rows.Count > 0)
                {
                    
                    Form5 f = new Form5(int.Parse(table.Rows[0][0].ToString()));
                    f.Show();
                    this.Close();


                }
                else
                {

                    throw new Exception("there is no such account exist");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }
    }
}
