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
    public partial class Form2 : Form
    {
        public Form1 mainForm;
        public Form2()
        {
            InitializeComponent();
            textBox7.PasswordChar = '*';
            textBox8.PasswordChar = '*';
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String name = textBox1.Text;
                String email = textBox2.Text;
                String phone = textBox3.Text;
                String hospital="P";
                if (radioButton4.Checked)
                {
                    hospital = "G";
                }
                int postindex = (int.Parse(textBox5.Text)/1000)*1000;

                String vaccine="Спутник-5";
                if (radioButton1.Checked)
                {
                    vaccine = "КовиВак";
                }

                String password = textBox7.Text;
                String repeatpassword = textBox8.Text;

                if (password != repeatpassword)
                {
                    throw new Exception("Пароли не подходят");
                }

                Db db = new Db();
                MySqlCommand command = new MySqlCommand("INSERT INTO hospital (h_name, h_pwd, h_contactno, h_type, h_address, h_email, h_vac, quant_rem) VALUES (@name, @pwd, @contactno, @type, @address, @email, @vac, @rem)", db.GetConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = password;
                command.Parameters.Add("@contactno", MySqlDbType.Decimal).Value = phone;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = hospital;
                command.Parameters.Add("@address", MySqlDbType.Decimal).Value = postindex;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@vac", MySqlDbType.VarChar).Value = vaccine;
                command.Parameters.Add("@rem", MySqlDbType.Int32).Value = 0;
                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт был создан!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            this.Close();
        }
    }
}
