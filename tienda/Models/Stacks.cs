using System;
namespace tienda.Models
{
    public class Stacks
    {
        // variables de referencia
        private Nodo cabecera;
        private Nodo referencia;
        private Nodo referenciaventas;

        public Stacks(){
            //inicializamos la cabecera
            cabecera = new Nodo();
            //Como la pila esta vacia, entonces su primer valor a null
            cabecera.Siguiente = null;
        }
        public void Push(int Codigo,int tipo){
            //crea nodo temporal
            if(Codigo > 9 || Codigo < 1)
            {
                return;
            }
            Nodo tmp = new Nodo();
            tmp.Codigo = Codigo;
            tmp.Tipo = tipo;
            tmp.Nombre = Nombre(Codigo, tipo);
            tmp.Precio = Precio(Codigo, tipo);
            tmp.Siguiente = cabecera.Siguiente;
            cabecera.Siguiente = tmp;
        }
        public string UltimoNombre()
        {
            string nombre = "";
            if(cabecera.Siguiente != null)
            {
                referencia = cabecera.Siguiente;
                nombre = referencia.Nombre;
            }
            return nombre;
        }
        public int UltimoPrecio()
        {
            int valor = 0;
            if(cabecera.Siguiente != null)
            {
                referencia = cabecera.Siguiente;
                valor = referencia.Precio;
            }
            return valor;
        }
        public int Ventas()
        {
            int total = 0;
            referenciaventas = cabecera;
            while (referenciaventas.Siguiente != null)
            {
                total = total + referenciaventas.Siguiente.Precio;
                Console.WriteLine(total);
                referenciaventas = referenciaventas.Siguiente;
            }
            return total;
        }
        //puntero
        private string Nombre(int pCodigo, int tipo)
        {
            switch (tipo)
            {
                case 1:
                switch (pCodigo)
                {
                    case 1:
                    return "Camisa roja";

                    case 2:
                    return "Camisa azul";

                    case 3:
                    return "Camisa amarilla";

                    case 4:
                    return "Camisa rosada";

                    case 5:
                    return "Camisa verde";

                    case 6:
                    return "Camisa naranja";

                    case 7:
                    return "Camisa negra";

                    case 8:
                    return "Camisa blanca";

                    case 9:
                    return "Camisa morada";

                    default:
                    return "producto invalido";
                }
                case 2:
                switch (pCodigo)
                {
                    case 1:
                    return "Pantalon cafe";

                    case 2:
                    return "Jean";

                    case 3:
                    return "Pantaloneta";

                    case 4:
                    return "Sudadera";

                    case 5:
                    return "Pantalon blanco";

                    case 6:
                    return "Vermuda beige";

                    case 7:
                    return "Vermuda blanca";

                    case 8:
                    return "Vermuda negra";

                    case 9:
                    return "Jean negro";

                    default:
                    return "producto invalido";
                }

                case 3:
                    switch (pCodigo)
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
                
                case 4:
                switch (pCodigo)
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

                default:
                return "producto invalido";
            }
            
        }
        private int Precio(int pCodigo, int tipo)
        {
            switch (tipo)
            {
                case 1:
                switch (pCodigo)
                {
                    case 1:
                    return 30000;

                    case 2:
                    return 25000;

                    case 3:
                    return 27500;

                    case 4:
                    return 29500;

                    case 5:
                    return 15000;

                    case 6:
                    return 17500;

                    case 7:
                    return 29000;

                    case 8:
                    return 12500;

                    case 9:
                    return 17000;

                    default:
                    return 0;
                }
                case 2:
                switch (pCodigo)
                {
                    case 1:
                    return 50000;

                    case 2:
                    return 45000;

                    case 3:
                    return 20000;

                    case 4:
                    return 25000;

                    case 5:
                    return 55000;

                    case 6:
                    return 35000;

                    case 7:
                    return 35000;

                    case 8:
                    return 35000;

                    case 9:
                    return 50000;

                    default:
                    return 0;
                }

                case 3:
                    switch (pCodigo)
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
                
                case 4:
                switch (pCodigo)
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
                default:
                return 0;
            }
        }
    }
}