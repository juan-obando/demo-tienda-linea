using System;
namespace tienda.Models
{
    public class Nodo{
        //datos que vamos a almacenar
        private int tipo;
        private string nombre;
        private int codigo;
        private int precio;
        //crear una variable (referencia al nodo siguiente)
        private Nodo siguiente = null;

        //propiedades Setter y Getter
        public int Tipo { get => tipo; set => tipo = value;}
        public string Nombre { get => nombre; set => nombre = value;}
        public int Codigo { get => codigo; set => codigo = value;}
        public int Precio { get => precio; set => precio = value;}

        internal Nodo Siguiente {get => siguiente; set => siguiente = value;}

        //ver mas facil
        public override string ToString()
        {
        return string.Format("[{0} {1} {2} ${3}]", tipo, codigo, nombre, precio);
        }

    }
}
    