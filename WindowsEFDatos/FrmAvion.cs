using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class FrmAvion : Form
    {
        public FrmAvion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            {
                
                Avion avion = new Avion() { Capacidad = Convert.ToInt32(txtCapacidad.Text), Demonimacion= txtDenominacion.Text, IdLinea = Convert.ToInt32(txtLineaId.Text) };

                int filasAfectadas = AbmAvion.Insert(avion);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Insert ok");
                    Mostrartodoslosaviones();

                }
            }


        }

        private void GridAvion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAvion_Load(object sender, EventArgs e)
        {
            Mostrartodoslosaviones();

        }
        private void Mostrartodoslosaviones()
        {
            
            GridAvion.DataSource = AbmAvion.SelectAll();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Capacidad = Convert.ToInt32(txtCapacidad.Text), Demonimacion = txtDenominacion.Text, AvionID= Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmAvion.Update(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modificar ok");
                Mostrartodoslosaviones();

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { AvionID=Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmAvion.Delete(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Borrar ok");
                Mostrartodoslosaviones();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        
            int id = Convert.ToInt32(txtId.Text);
            Avion avion = AbmAvion.SelectWhereById(id);
            MessageBox.Show(avion.Demonimacion);
        }
        
    }
}
