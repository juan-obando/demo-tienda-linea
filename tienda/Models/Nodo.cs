using System;
namespace tienda.Models
{
    public class Nodo{
        //datos que vamos a almacenar
        private int codigo;
        private string nombre;
        private int precio;
        //crear una variable (referencia al nodo siguiente)
        private Nodo siguiente = null;

        //propiedades Setter y Getter
        public int Codigo { get => codigo; set => codigo = value;}
        public string Nombre { get => nombre; set => nombre = value;}
        public int Precio { get => precio; set => precio = value;}

        internal Nodo Siguiente {get => siguiente; set => siguiente = value;}

        //ver mas facil
        public override string ToString()
        {
        return string.Format("[{0}]", codigo);
        }

    }
}
    