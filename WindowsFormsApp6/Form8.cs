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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 

            String name = textBox1.Text;
            String phone = textBox3.Text;
            int postindex = (int.Parse(textBox5.Text) / 1000) * 1000;

            Db db = new Db();
            MySqlCommand command = new MySqlCommand("INSERT INTO inventory (i_name, i_contactno, i_address) VALUES (@name, @contactno, @address)", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
         
            command.Parameters.Add("@contactno", MySqlDbType.Decimal).Value = phone;
       
            command.Parameters.Add("@address", MySqlDbType.Decimal).Value = postindex;
          
            
            
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
