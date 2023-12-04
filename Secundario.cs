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
    public partial class Secundario : Form
    {

        bool modoEdicion;
        private DataGridView gridViewHotel;
        public Secundario(DataGridView gVHotel, bool modo)
        {
            //bool modo
            this.gridViewHotel = gVHotel;
            this.modoEdicion = modo;
            InitializeComponent();
            // if (modoEdicion)


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                int num = Int32.Parse(txtNum.Text);
                if (num < 100)
                {
                    MessageBox.Show("Los números de las habitaciones son de 100 en adelante");
                    return;
                }

                string sql = "insert into Hotel_habitaciones (No_habitacion, tipo_habitacion, descripcion_habitacion, capacidad) values(" + txtNum.Text+", '" +combTipo.Text+"', '"+txtDescri.Text+"',"+combCapa.Text+")";
                
                int resultado = SQLquery.execute(sql);
                if (resultado > 0)
                {
                    MessageBox.Show("Habitación agregada correctamente :)");
                    string sql2 = "select * from Hotel_habitaciones";
                    gridViewHotel.DataSource = SQLquery.getTable(sql2);
                }
                    
                else
                    MessageBox.Show("Hubo un error");
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Información ingresada incompleta!!!!");
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            combTipo.SelectedIndex = -1;
            txtDescri.Clear();
            combCapa.SelectedIndex = -1; 


        }
    }

    
}
