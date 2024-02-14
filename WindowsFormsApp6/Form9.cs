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
    public partial class Form9 : Form
    {
        List<string> list = new List<string>();
        int id;
        public Form9(string p_address, int p_id)
        {
            id = p_id;
            InitializeComponent();


            Db db = new Db();

            MySqlCommand command = db.GetConnection().CreateCommand();
            Console.WriteLine(p_address);
            
            command.CommandText = "SELECT * from hosp_data WHERE h_address=((@address/1000)*1000)";
            command.Parameters.AddWithValue("@address", p_address);
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            string first;
            
            
            while (reader.Read())
            {
               
                if (reader.GetString(3) == "G")
                {
                    first = String.Format(" Государственная {0}-{1}", reader.GetString(1), reader.GetString(6));
                }
                else
                {
                    first = String.Format(" Частная {0}-{1}", reader.GetString(1), reader.GetString(6));
                }
                domainUpDown1.Items.Add(first);
                list.Add(reader.GetString(0));
            }



            db.CloseConnection();
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            try
            {

                int h_id = int.Parse(list[domainUpDown1.SelectedIndex]);
                Db db = new Db();
                MySqlCommand command = new MySqlCommand("INSERT INTO vaccinates (p, hosp) VALUES (@person, @hospital)", db.GetConnection());
                command.Parameters.Add("@person", MySqlDbType.Int32).Value = id;

                command.Parameters.Add("@hospital", MySqlDbType.Int32).Value = h_id;

                



                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы успешно встали в очередь на прививку!");

                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


            this.Close();

        }
    }
}
