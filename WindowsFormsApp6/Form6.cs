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
    public partial class Form6 : Form
    {
        int id;
        public Form5 mainform;
        Db db;

        public Form6(int id)
        {
            this.id = id;
            db = new Db();
            
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            Refresh1();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Refresh1()
        {

            try
            {

                DataTable table = new DataTable();
                
                
                MySqlCommand command = new MySqlCommand("SELECT * FROM ( select i.*, s.s_time,s.S_quantity from inventory i join supplies s on s_inventory = i.i_id join hosp_data h on h.h_id = s.s_hospital where h.h_id = @id order by s.s_time desc) AS A JOIN ( select v.v_cost*s.s_quantity from hosp_data h join vaccine v on v.v_name = h.h_vac join supplies s on s.s_hospital = h.h_id where h.h_id = @id order by s.s_time desc) AS B", db.GetConnection());
               
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                db.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();

                table.Load(reader);
                
                dataGridView1.DataSource = table;

               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {

                int I_id = int.Parse(textBox1.Text);
                int num = int.Parse(textBox2.Text);
                string date = dateTimePicker1.CustomFormat;

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                MySqlCommand command = new MySqlCommand("INSERT INTO supplies (s_hospital, s_inventory, s_quantity, s_time) VALUES (@hospid, @inventoryid, @quant, @time)", db.GetConnection());
          
                command.Parameters.Add("@hospid", MySqlDbType.Int32).Value=id;
                command.Parameters.Add("@inventoryid", MySqlDbType.Int32).Value = I_id;
                command.Parameters.Add("@quant", MySqlDbType.Decimal).Value = num;
                command.Parameters.Add("@time", MySqlDbType.Timestamp).Value = date;
               
                

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Заказ сделан");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
           
            mainform.Refresh1();
            db.CloseConnection();

            this.Close();
          

        }
    }
}
