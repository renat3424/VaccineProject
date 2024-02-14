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
    public partial class Form5 : Form
    {
        int id;
        Db db;
        public Form5(int h_id)
        {
            id = h_id;
            db = new Db();

            InitializeComponent();

            Refresh1();



            try
            {
               
                DataTable table = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("select * from inventory", db.GetConnection());
                

                adp.SelectCommand = command;
                adp.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridView1.DataSource = bSource;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        public void Refresh1()
        {
           

            MySqlCommand command = db.GetConnection().CreateCommand();

            command.CommandText = "SELECT * from hospital WHERE h_id = @id";
            command.Parameters.AddWithValue("@id", id);
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();



            reader.Read();
            label1.Text = reader.GetString(1);

            label5.Text = reader.GetString(3);
            label2.Text = "Частная";
            if (reader.GetString(4) == "G")
            {
                label2.Text = "Государственная";
            }

            label3.Text = reader.GetString(6);
            label8.Text = reader.GetString(7);
            label10.Text = reader.GetString(8);



            db.CloseConnection();



        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6(id);
            f.mainform = this;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form7 f = new Form7(id);
             f.mainform = this;
            f.Show();
        }
    }
}
