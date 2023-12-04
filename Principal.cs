using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_Hotel
{
    public partial class Principal : Form



    {

        public Principal()
        {
            
            InitializeComponent();
            string sql = "select * from Hotel_habitaciones";
            GridView1.DataSource = SQLquery.getTable(sql);

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Secundario hotel_habita = new Secundario(this.GridView1, false);
            hotel_habita.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Hotel_habitaciones SET reservado=0 WHERE No_habitacion= " + textBox1.Text + "";
                int resultado = SQLquery.execute(sql);
                if (resultado > 0)
                {
                    MessageBox.Show("Habitación libre :)");
                    string sql2 = "select * from Hotel_habitaciones";
                    GridView1.DataSource = SQLquery.getTable(sql2);
                }
                else
                    MessageBox.Show("Hubo un error");

            }
            catch 
            {
            }

        }

        private void brn_reservar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Hotel_habitaciones SET reservado=1 WHERE No_habitacion= " + textBox1.Text +"";
                int resultado = SQLquery.execute(sql);
                if (resultado > 0)
                {
                    MessageBox.Show("Habitación reservada :)");
                    string sql2 = "select * from Hotel_habitaciones";
                    GridView1.DataSource = SQLquery.getTable(sql2);
                }
                else
                    MessageBox.Show("Hubo un error");

            }
            catch 
            {
            }
        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text =GridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void GridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
