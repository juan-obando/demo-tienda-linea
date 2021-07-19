using System;
namespace tienda.Models
{
    public class Vector
    {
        public int[] producto = new int[100];
        public string[] nombre = new string[100];
        public int[] precio = new int [100];
        int Tipo = 0;
        int Ventas = 0;

        private int indice = 0;
        public void Adicionar(int codigo, int tipo)
        {
            
            Tipo = tipo;
            if (indice >= Largo(producto) || indice < 0 || codigo < 1 || codigo > 9)
            {
                return;
            }
            producto[indice] = codigo;
            nombre[indice] = Nombre(producto[indice]);
            precio[indice] = Precio(producto[indice]);
            indice++;
        }
        public int Largo(int[] vec)
        {
            int largo = vec.Length;
            return largo;
        }
        public void Modificar(int pos, int codigo)
        {
            if (pos >= Largo(producto) || pos < 0)
            {
                return;
            }
            else
            {
                producto[pos] = codigo;
            }
        }
        public void Borrar (int pos, int codigo)
        {
          if (pos >= Largo(producto) || pos < 0 || producto[pos] == 0)
            {
                return;
            }
            else
            {
                if (pos == Largo(producto) - 1)
                {
                    producto[pos] = 0;
                    nombre[pos] = "";
                    Ventas = Ventas + precio[pos];
                    precio[pos] = 0;
                    indice--;
                }
                else
                {
                    Ventas = Ventas + precio[pos];
                    for (int i = pos; i < Largo(producto) - 1; i++)
                    {
                        producto[pos] = producto[pos + 1];
                        nombre[pos] = nombre[pos + 1];
                        precio[pos] = precio[pos + 1];
                        producto[pos + 1] = 0;
                        nombre[pos + 1] = "";
                        precio[pos + 1] = 0;
                    }
                    indice--;
                }
            }  
        }
        public void PrintArray()
        {
            foreach(var item in producto)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine();
            foreach(var item in nombre)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine();
            foreach(var item in precio)
            {
                Console.Write("{0}  ", item);
            }
            Console.WriteLine();
        }

        private string Nombre(int Codigo)
        {
            if (Tipo == 3)
            {
                switch (Codigo)
                {
                    case 1:
                    return "Tennis blancos";

                    case 2:
                    return "Chanclas hombre";

                    case 3:
                    return "Mocasines";

                    case 4:
                    return "Tacones";

                    case 5:
                    return "Babuchas";

                    case 6:
                    return "Tennis negros";

                    case 7:
                    return "Zapato negro";

                    case 8:
                    return "Zapato cafe";

                    case 9:
                    return "Chanclas mujer";

                    default:
                    return "producto invalido";
                }
            }
            else
            {
                switch (Codigo)
                {
                    case 1:
                    return "Gorra normal";

                    case 2:
                    return "Gorra pescador";

                    case 3:
                    return "Sombrero de paja";

                    case 4:
                    return "Gorra de lana roja";

                    case 5:
                    return "Gorra de lana negra";

                    case 6:
                    return "Gorra de lana blanca";

                    case 7:
                    return "Gorra plana";

                    case 8:
                    return "Fedora negra";

                    case 9:
                    return "Fedora blanca";

                    default:
                    return "producto invalido";
                }
            } 
        }
        private int Precio(int Codigo)
        {
            if (Tipo == 3)
            {
                switch (Codigo)
                {
                    case 1:
                    return 100000;

                    case 2:
                    return 20000;

                    case 3:
                    return 150000;

                    case 4:
                    return 170000;

                    case 5:
                    return 30000;

                    case 6:
                    return 110000;

                    case 7:
                    return 90000;

                    case 8:
                    return 85000;

                    case 9:
                    return 25000;

                    default:
                    return 0;
                }
            }
            else
            {
                switch (Codigo)
                {
                    case 1:
                    return 20000;

                    case 2:
                    return 22500;

                    case 3:
                    return 30000;

                    case 4:
                    return 27500;

                    case 5:
                    return 28000;

                    case 6:
                    return 28500;

                    case 7:
                    return 23000;

                    case 8:
                    return 50000;

                    case 9:
                    return 50500;

                    default:
                    return 0;
                }
            } 
        }

    }
}