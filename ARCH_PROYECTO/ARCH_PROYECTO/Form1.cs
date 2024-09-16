using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ARCH_PROYECTO
{
    public partial class Form1 : Form
    {
        Cooperativa a1, a2;

        int codigo, nr = 0;
        int cod = 0;
        string nom = "";
        string categoria = "";
        double cantidad = 0;
        double costo = 0;
        double peso = 0;
        double ingresos = 0;
        string ubicacion = "";
        bool est = false;

        int nr1, cod1 = 0;
        string r1, r2 = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            a1 = new Cooperativa();
            a2 = new Cooperativa();
        }
        public void limpiar()
        {
            dataGridView1.Rows.Clear();
            textBox1.Text = "";
        }
        // Limpiar
        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //Creacion
        private void creacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            a1.Abrir_Grab(saveFileDialog1.FileName);
            do
            {
                codigo = int.Parse(Interaction.InputBox("Ingrese codigo multiplo de 1000"));
            } while (codigo % 1000 != 0);
            nr = 1;
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
        }

        // Grabar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a1.Grabar(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[1].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[2].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[6].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[7].Value), true);
                limpiar();
                nr++;
                dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
                dataGridView1.Rows[0].Cells[0].ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        // Terminar
        private void button2_Click(object sender, EventArgs e)
        {
            if (nr > 0)
                a1.Cerrar_Grab();
            else
                MessageBox.Show("Garbar al menos 1 registro");
        }

        // Accesar
        private void accesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            a1.Abrir_Leer(openFileDialog1.FileName);
            nr = -1;
            while (!a1.Verif_Fin())
            {
                a1.Leer(ref cod, ref nom, ref categoria, ref cantidad , ref costo, ref peso, ref ingresos, ref ubicacion, ref est);
                if (est == true)
                {
                    nr++;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[nr].Cells[0].Value = Convert.ToString(cod);
                    dataGridView1.Rows[nr].Cells[1].Value = Convert.ToString(nom);
                    dataGridView1.Rows[nr].Cells[2].Value = Convert.ToString(categoria);
                    dataGridView1.Rows[nr].Cells[3].Value = Convert.ToString(cantidad);
                    dataGridView1.Rows[nr].Cells[4].Value = Convert.ToString(costo);
                    dataGridView1.Rows[nr].Cells[5].Value = Convert.ToString(peso);
                    dataGridView1.Rows[nr].Cells[6].Value = Convert.ToString(ingresos);
                    dataGridView1.Rows[nr].Cells[7].Value = Convert.ToString(ubicacion);
                }
            }
            a1.Cerrar_Leer();
        }

        // Altas
        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            a1.Abrir_Leer(openFileDialog1.FileName);
            a1.Leer(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est);
            codigo = cod - 1;
            a1.Cerrar_Leer();
            a1.Abrir_Adicionar(openFileDialog1.FileName);
            nr = a1.NRegs() + 1;
            dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
        }

        //Bajas
        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nr1, cod1 = 0;
            string r1, r2 = "";

            openFileDialog1.ShowDialog();
            a1.Abrir_Bajas(openFileDialog1.FileName);

            a1.LeerR(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est, 1);
            codigo = cod - 1;
            nr = a1.NRegs();
            do
            {
                cod1 = int.Parse(Interaction.InputBox("N° Codigo para Baja: "));
                if ((cod1 >= codigo + 1) && (cod1 <= codigo + nr))
                {
                    nr1 = cod1 - codigo;
                    a1.LeerR(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est, nr1);
                    if (est == true)
                    {
                        dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(cod);
                        dataGridView1.Rows[0].Cells[1].Value = Convert.ToString(nom);
                        dataGridView1.Rows[0].Cells[2].Value = Convert.ToString(categoria);
                        dataGridView1.Rows[0].Cells[3].Value = Convert.ToString(cantidad);
                        dataGridView1.Rows[0].Cells[4].Value = Convert.ToString(costo);
                        dataGridView1.Rows[0].Cells[5].Value = Convert.ToString(peso);
                        dataGridView1.Rows[0].Cells[6].Value = Convert.ToString(ingresos);
                        dataGridView1.Rows[0].Cells[7].Value = Convert.ToString(ubicacion);
                        do
                        {
                            r1 = Interaction.InputBox("Esta seguro: 1=Si o 2=No");
                        } while (!(r1 == "1") || (r1 == "2"));
                        if (r1 == "1")
                        {
                            a1.GrabarR(cod, nom, categoria, cantidad, costo, peso, ingresos, ubicacion, false, nr1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El codigo esta con baja");
                    }

                }
                else
                {
                    MessageBox.Show("Codigo no Valido");
                }
                limpiar();
                r2 = Interaction.InputBox("Desea continuar con Bajas: 1 = Si o 2 = No  ");
            } while (r2 == "1");
            a1.Cerrar_Bajas();
            //limpiar();
        }

        //Modificaciones
        private void modificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            a1.Abrir_Bajas(openFileDialog1.FileName);

            a1.LeerR(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est, 1);
            codigo = cod - 1;
            nr = a1.NRegs();

            cod1 = int.Parse(Interaction.InputBox("N° Codigo a Modificar:"));
            if ((cod1 >= codigo + 1) && (cod1 <= codigo + nr))
            {
                nr1 = cod1 - codigo;
                a1.LeerR(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso,
                    ref ingresos, ref ubicacion, ref est, nr1);
                if (est == true)
                {
                    dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(cod);
                    dataGridView1.Rows[0].Cells[1].Value = Convert.ToString(nom);
                    dataGridView1.Rows[0].Cells[2].Value = Convert.ToString(categoria);
                    dataGridView1.Rows[0].Cells[3].Value = Convert.ToString(cantidad);
                    dataGridView1.Rows[0].Cells[4].Value = Convert.ToString(costo);
                    dataGridView1.Rows[0].Cells[5].Value = Convert.ToString(peso);
                    dataGridView1.Rows[0].Cells[6].Value = Convert.ToString(ingresos);
                    dataGridView1.Rows[0].Cells[7].Value = Convert.ToString(ubicacion);
                }
                else
                {
                    MessageBox.Show("El codigo esta con baja");
                }
            }
            else
            {
                MessageBox.Show("Codigo no Valido");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            r1 = Interaction.InputBox("Esta seguro: 1= Si o 2= No");

            if (r1 == "1")
            {
                a1.GrabarR(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),
                    Convert.ToString(dataGridView1.Rows[0].Cells[1].Value),
                    Convert.ToString(dataGridView1.Rows[0].Cells[2].Value),
                    Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value),
                    Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value),
                    Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value),
                    Convert.ToDouble(dataGridView1.Rows[0].Cells[6].Value),
                    Convert.ToString(dataGridView1.Rows[0].Cells[7].Value), true, nr1);
            }
            else
            {
                MessageBox.Show("No se modifico");
            }
            a1.Cerrar_Bajas();
            limpiar();
        }
// GrabarN
        private void button5_Click(object sender, EventArgs e)
        { 
        
            try
            {
                a1.Grabar(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[1].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[2].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[6].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[7].Value), true);
                limpiar();
                nr++;
                dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
                dataGridView1.Rows[0].Cells[0].ReadOnly = true;

                saveFileDialog1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

    



        // Seleccionar Socios con Codigos Pares o Impares en otro archivo
        private void seleccionDeCoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char opcion = ' ';
            openFileDialog1.ShowDialog();
            opcion = char.Parse(Interaction.InputBox("Codigo: (P=Par o I=Impar ) "));
            saveFileDialog1.ShowDialog();

            a1.SeleccionCodigoParImpar(opcion, openFileDialog1.FileName, saveFileDialog1.FileName, a2);

        }



        // Seleccionar Coops con más de N Ingresos anuales


        private void seleccionarCoopConMasIngresosAnualesDesdeXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            double hect = double.Parse(Interaction.InputBox("IngresosAnuales > que: ...."));
            saveFileDialog1.ShowDialog();
            a1.Seleccionar_coop_con_mas_de_N_hectarias_de_tierra(hect, openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }

        private void sellecionarCoopConMenosIngresosAnualesDesdeXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            double hect = double.Parse(Interaction.InputBox("IngresosAnuales < que: ...."));
            saveFileDialog1.ShowDialog();
            a1.Seleccionar_coop_con_menos_de_N_hectarias_de_tierra(hect, openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }
    
        // Cantidad de SociosCoope dada una categoria	

        private void superfTotalDecadaHectporCoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cat;
            openFileDialog1.ShowDialog();
            cat = (Interaction.InputBox("Categoria: "));
            textBox1.Text = "Cantidad total: " + string.Concat(a1.CantidadTotaldeSociosxCategoria(cat, openFileDialog1.FileName));
        }


    }
}
