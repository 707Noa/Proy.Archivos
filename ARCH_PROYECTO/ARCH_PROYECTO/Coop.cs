using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ARCH_PROYECTO
{
    class Cooperativa
    {
        string Narch;
        FileStream stream;
        BinaryWriter writer1;
        BinaryReader reader1;

        int cod = 0;
        string nom = "";
        string categoria = "";
        double cantidad = 0;
        double costo = 0;
        double peso = 0;
        double ingresos = 0;
        string ubicacion = "";
        bool est = false;
        public Cooperativa()
        {
            Narch = "";
        }

        //Abrir para Grabar
        public void Abrir_Grab(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.CreateNew, FileAccess.Write);
            writer1 = new BinaryWriter(stream);
        }

        // Abrir para leer
        public void Abrir_Leer(string Narch1) // abrir para leer
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Open, FileAccess.Read);
            reader1 = new BinaryReader(stream);
            // writer1 = new BinaryWriter(stream);
        }

        // Abrir para dar de Baja
        public void Abrir_Bajas(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Open, FileAccess.ReadWrite);
            reader1 = new BinaryReader(stream);
            writer1 = new BinaryWriter(stream);
        }
        //abrir modificar
        public void Abrir_m(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Open, FileAccess.ReadWrite);
            reader1 = new BinaryReader(stream);
            writer1 = new BinaryWriter(stream);
        }

        //Abrir para Adicionar
        public void Abrir_Adicionar(string Narch1)
        {
            Narch = Narch1;
            stream = new FileStream(Narch, FileMode.Append, FileAccess.Write);
            writer1 = new BinaryWriter(stream);
        }

        //Grabar
        public void Grabar(int cod, string nom, string categoria, double cantidad,
            double costo, double peso, double ingresos, string ubicacion, bool est)
        {
            nom = nom.PadRight(21, ' ').Substring(0, 21);
            categoria = categoria.PadRight(9, ' ').Substring(0, 9);
            ubicacion = ubicacion.PadRight(19, ' ').Substring(0, 19);
            writer1.Write(cod);
            writer1.Write(nom);
            writer1.Write(categoria);
            writer1.Write(cantidad);
            writer1.Write(costo);
            writer1.Write(peso);
            writer1.Write(ingresos);
            writer1.Write(ubicacion);
            writer1.Write(est);
        }

        //Grabar por num de Registro
        public void GrabarR(int cod, string nom, string categoria, double cantidad,
             double costo, double peso, double ingresos, string ubicacion, bool est, int nr)
        {
            //writer1 = new BinaryWriter(stream);
            nr = (nr - 1) * 89;
            stream.Seek(nr, SeekOrigin.Begin);
            nom = nom.PadRight(21, ' ').Substring(0, 21);
            categoria = categoria.PadRight(9, ' ').Substring(0, 9);
            ubicacion = ubicacion.PadRight(19, ' ').Substring(0, 19);
            writer1.Write(cod);
            writer1.Write(nom);
            writer1.Write(categoria);
            writer1.Write(cantidad);
            writer1.Write(costo);
            writer1.Write(peso);
            writer1.Write(ingresos);
            writer1.Write(ubicacion);
            writer1.Write(est);
        }

        //Cerrar Grabacion
        public void Cerrar_Grab()
        {
            writer1.Close();
            stream.Close();
        }        

        // Leer
         public void Leer(ref int cod, ref string nom, ref string categoria, ref double cantidad, 
            ref double costo, ref double peso, ref double ingresos, ref string ubicacion, ref bool est)
        {
            cod = reader1.ReadInt32();
            nom = reader1.ReadString();
            categoria = reader1.ReadString();
            cantidad = reader1.ReadDouble();
            costo = reader1.ReadDouble();
            peso = reader1.ReadDouble();
            ingresos = reader1.ReadDouble();
            ubicacion = reader1.ReadString();
            est = reader1.ReadBoolean();
        }

        // Leer dado un Registro
        public void LeerR(ref int cod, ref string nom, ref string categoria, ref double cantidad,
              ref double costo, ref double peso, ref double ingresos, ref string ubicacion, ref bool est, int nr)
        {
            nr = (nr - 1) * 89;
            stream.Seek(nr, SeekOrigin.Begin);
            cod = reader1.ReadInt32();
            nom = reader1.ReadString();
            categoria = reader1.ReadString();
            cantidad = reader1.ReadDouble();
            costo = reader1.ReadDouble();
            peso = reader1.ReadDouble();
            ingresos = reader1.ReadDouble();
            ubicacion = reader1.ReadString();
            est = reader1.ReadBoolean();
        }

        // Cerrar
        public void Cerrar_Leer()
        {
            reader1.Close();
            stream.Close();
        }
        public void Cerrar_Bajas()
        {
            stream.Position = stream.Length;
            reader1.Close();
            writer1.Close();
            stream.Close();
        }

        // Verificar Fin
        public bool Verif_Fin()
        {
            return stream.Position == stream.Length;
        }
        public int NRegs()
        {
            return (int)stream.Length / 89;
        }



       

  
      




        // Seleccionar Socios con Codigos Pares o Impares en otro archivo

        public void SeleccionCodigoParImpar(char opcion, string Narch1, string Narch2, Cooperativa a2)
         {
             this.Abrir_Leer(Narch1);
             a2.Abrir_Grab(Narch2);

             if (opcion == 'P' | opcion == 'p')
             {
                 while (!this.Verif_Fin())
                 {
                     this.Leer(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est);
                     if (est == true & (cod % 2 == 0))
                     {
                         a2.Grabar(cod, nom, categoria, cantidad, costo, peso, ingresos, ubicacion, est);
                     }
                 }
             }
             if (opcion == 'I' | opcion == 'i')
             {
                 while (!this.Verif_Fin())
                 {
                     this.Leer(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est);
                     if (est == true & (cod % 2 == 1))
                     {
                         a2.Grabar(cod, nom, categoria, cantidad, costo, peso, ingresos, ubicacion, est);
                     }
                 }
             }

                     this.Cerrar_Leer();
             a2.Cerrar_Grab();
         }
       













        // Seleccionar Coops con más de N dinero
        public void Seleccionar_coop_con_mas_de_N_hectarias_de_tierra(double hect, string Narch1, string Narch2, Cooperativa a2)
        {
            this.Abrir_Leer(Narch1);
            a2.Abrir_Grab(Narch2);


            while (!Verif_Fin())
            {
                this.Leer(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est);
                if (est == true & (ingresos > hect))
                {
                    a2.Grabar(cod, nom, categoria, cantidad, costo, peso, ingresos, ubicacion, est);
                }
            }

            this.Cerrar_Leer();
            a2.Cerrar_Grab();
        }
        // Seleccionar Coops con menos de N dinero
        public void Seleccionar_coop_con_menos_de_N_hectarias_de_tierra(double hect, string Narch1, string Narch2, Cooperativa a2)
        {
            this.Abrir_Leer(Narch1);
            a2.Abrir_Grab(Narch2);


            while (!Verif_Fin())
            {
                this.Leer(ref cod, ref nom, ref categoria, ref cantidad, ref costo, ref peso, ref ingresos, ref ubicacion, ref est);
                if (est == true & (ingresos < hect))
                {
                    a2.Grabar(cod, nom, categoria, cantidad, costo, peso, ingresos, ubicacion, est);
                }
            }

            this.Cerrar_Leer();
            a2.Cerrar_Grab();
        }






        // Cantidad de Socios de Cooperativas dada una categoria
        public double CantidadTotaldeSociosxCategoria(string cat, string Narch1)
        {
            double cantSociosCoop = 0;
            this.Abrir_Leer(Narch1);
            while (!Verif_Fin())
            {
                this.Leer(ref cod, ref nom, ref categoria, ref cantidad, ref costo,
                    ref peso, ref ingresos, ref ubicacion, ref est);
                cat = cat.Trim();
                categoria = categoria.Trim();
                if (est == true & (categoria == cat))
                {
                    cantSociosCoop++;
                }
            }
            this.Cerrar_Leer();
            return cantSociosCoop;
        }
    }
}
