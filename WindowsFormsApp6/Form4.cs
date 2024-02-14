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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                String email = textBox2.Text;
                String phone = textBox3.Text;
                String  gender= "Male";
                if (radioButton2.Checked)
                {
                    gender = "Female";
                }
                string postindex = textBox6.Text;

                
               

                Db db = new Db();
                MySqlCommand command = new MySqlCommand("INSERT INTO person (p_name, p_contactno, p_address, p_email, p_gender, p_dob) VALUES (@name, @contactno, @address, @email, @gender, @dob)", db.GetConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
              
                command.Parameters.Add("@contactno", MySqlDbType.Decimal).Value = phone;
          
                command.Parameters.Add("@address", MySqlDbType.Decimal).Value = int.Parse(postindex.Substring(0, 3))*1000;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@dob", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;

                db.OpenConnection();
                command.ExecuteNonQuery();

                Form9 f = new Form9(postindex, (int)command.LastInsertedId);
                
               
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


            
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
