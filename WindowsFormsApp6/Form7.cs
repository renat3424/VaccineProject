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


    public partial class Form7 : Form
    {
        int id;
        Db db;
        public Form5 mainform;
        public Form7(int id)
        {
            db = new Db();
            this.id = id;
            InitializeComponent();
            Refresh1();
        }


        public void Refresh1()
        {

            try
            {

                DataTable table = new DataTable();


                MySqlCommand command = new MySqlCommand("select p_id, p_name, p_gender, p_contactno, date_first, date_second from (select * from person p join vaccinates v on v.P = p.p_id join hosp_data h on v.hosp = h.h_id where h.h_id = @id) as a", db.GetConnection());
                command.Parameters.AddWithValue("@id", id);

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
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlCommand command = db.GetConnection().CreateCommand();

                command.CommandText = "SELECT quant_rem from hospital WHERE h_id = @id";
                command.Parameters.AddWithValue("@id", id);
                db.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();



                reader.Read();
                int numofvac= int.Parse(reader.GetString(0));
                if (numofvac == 0)
                {

                    throw new Exception("no vaccine left");
                }
                int p_num = int.Parse(textBox1.Text);
                reader.Close();


                db.CloseConnection();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE vaccinates SET Date_first=@date1,Date_second=@date2 WHERE P=@pid", db.GetConnection());

                sqlCommand.Parameters.Add("@date1", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                sqlCommand.Parameters.Add("@date2", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                sqlCommand.Parameters.AddWithValue("@pid", p_num);
                sqlCommand.Parameters.AddWithValue("@Hosp", id);
              
               
                    db.OpenConnection();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("sukses");
                    db.CloseConnection();


                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            Refresh1();
            mainform.Refresh1();
        }
    }
}
