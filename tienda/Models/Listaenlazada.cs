using System;
namespace tienda.Models
{
    public class ListaEnlazada{    
    //ancla, cabecera, head
    private Nodo cabecera;
    // variable de referencia ayuda a trabajar con la lista
    private Nodo referencia;
    private Nodo referencia2;
    private Nodo referenciaIndice;
    private Nodo referenciaBuscar;
    private Nodo referenciaBuscarCodigo;

    private Nodo referenciaInsertar;

    private Nodo refBuscarIndice;

    private Nodo refIndexer;

    public ListaEnlazada(){
        // instancia
        cabecera = new Nodo();
        cabecera.Siguiente = null;
    }

    //recorrer la lista

    public void Apuntador(){
        //referencia al inicio
        referencia = cabecera;
        //recorrer hasta encontrar el final (todos los elementos de la lista)
        while (referencia.Siguiente != null)
        {
            //avanzar a referencia
            referencia = referencia.Siguiente;
            //Obtener el Codigo
            int d = referencia.Codigo;
            Console.Write("{0} -> ", d);
        }
        Console.WriteLine();
    }
    // Adiciona nuevos elementos (siempre al final L.E.S)
    public void Adicionar(int pCodigo, int pTipo)
    {
        if (pCodigo < 1 || pCodigo > 9)
        {
            return;
        }
        else
        {
            //referencia al inicio
            referencia = cabecera;
            //recorrer hasta encontrar el final
            while (referencia.Siguiente != null)
            {
                referencia = referencia.Siguiente;
            }
            //crear un nuevo nodo
            Nodo tpm = new Nodo();
            //insertar Codigo
            tpm.Codigo = pCodigo;
            tpm.Tipo = pTipo;
            tpm.Nombre = Nombre(pTipo, pCodigo);
            tpm.Precio = Precio(pTipo, pCodigo);
            // enlazar
            referencia.Siguiente = tpm;
        }
    }
    // vacia la lista
    public void Vaciar(){
        cabecera.Siguiente = null;
    }
    // si la lista esta vacia o no
    public bool EstaVacia(){
        if (cabecera.Siguiente == null) {
            return true;
        } else {
            return false;
        }
    }

    // Regresar el nodo con el primer Codigo que encuentre
    public Nodo Buscar(int pCodigo){
        if (EstaVacia() == true)
        {
            return null;
        }


        referencia2 = cabecera;
        while (referencia2.Siguiente != null)
        {
            referencia2 = referencia2.Siguiente;
            //si lo encuentro = lo devuelvo
            if (referencia2.Codigo == pCodigo)
            {
                return referencia2;
            }
        }
        return null;
    }
    
    // Regresar el nodo cuando lo encuentra
    public int BuscarIndice(int pCodigo){
        int indice = -1;
        referenciaIndice = cabecera;
        while (referenciaIndice.Siguiente != null)
        {
            referenciaIndice = referenciaIndice.Siguiente;
            indice++;
            if (referenciaIndice.Codigo == pCodigo)
            {
                return indice;
            }
        }

        
        
        return -1;
    }

    public Nodo BuscarAnterior(int pCodigo){
        referenciaBuscar = cabecera;
        while (referenciaBuscar.Siguiente != null && referenciaBuscar.Siguiente.Codigo != pCodigo)
        {
            referenciaBuscar = referenciaBuscar.Siguiente;
        }

        return referenciaBuscar;
    }

    public int BuscarCodigoAnterior(int pCodigo){
        referenciaBuscarCodigo = cabecera;
        while (referenciaBuscarCodigo.Siguiente != null && referenciaBuscarCodigo.Siguiente.Codigo != pCodigo)
        {
            referenciaBuscarCodigo = referenciaBuscarCodigo.Siguiente;
        }

        return referenciaBuscarCodigo.Codigo;
    }
    

    public void Borrar(int pCodigo){
        //Verificar que hayan Codigos en la lista
        if (EstaVacia() == true){
            return;
        }
        //Buscar los nodos con los que se van a trabajar
        Nodo nodoAnterior = BuscarAnterior(pCodigo);
        Nodo nodoEncontrado = Buscar(pCodigo);

        //Si no hay nodos encontrados... salimos
        if (nodoEncontrado == null){
            return;
        }

        // Hacer el salto de nodo
        nodoAnterior.Siguiente = nodoEncontrado.Siguiente;
        //Quito el nodo de la lista (recolector de basura B) )
        nodoEncontrado.Siguiente = null;
    }

    public void Insertar(int pDonde, int pCodigo){
        //Se encuentra la posicion en la que se insertará
        referenciaInsertar = Buscar(pDonde);
        //Si no hay nodos, se sale
        if(referenciaInsertar == null){
            return;
        }
        //Se crea un nodo temporal
        Nodo añadir = new Nodo();
        añadir.Codigo = pCodigo;
        //Se le añade el nodo temporal a la lista
        añadir.Siguiente = referenciaInsertar.Siguiente;
        //Se conecta el nodo encontrado al temporal
        referenciaInsertar.Siguiente = añadir;
    }
    public void InsertarInicio(int pCodigo){
        //Se crea un nodo temporal
        Nodo añadirInicio = new Nodo();
        añadirInicio.Codigo = pCodigo;
        //Se conecta la lista con el temporal
        añadirInicio.Siguiente = cabecera.Siguiente;
        //se conecta el nodo temporal al inicio
        cabecera.Siguiente = añadirInicio;

    }
    //Obtener la referencia del nodo dado dando su indice
    public Nodo ObtenerPorIndice (int pIndice){

        Nodo nodoRegresado = null;
        int indice = -1;
        refBuscarIndice = cabecera;
        while(refBuscarIndice.Siguiente != null){
            refBuscarIndice = refBuscarIndice.Siguiente;            
            indice++;
            if(indice == pIndice){
                nodoRegresado = refBuscarIndice;
            }
        }
        return nodoRegresado;
    }

    //Indexador
    public int this[int pIndice]{
        get{
            refIndexer = ObtenerPorIndice(pIndice);
            return refIndexer.Codigo;
        }
        set{
            refIndexer = ObtenerPorIndice(pIndice);
            if (refIndexer != null){
                refIndexer.Codigo = value;
            }
        }
    }

    public int Cantidad(){
        int contador = 0;
        if(EstaVacia() == true){
            return contador;
        }
        referencia = cabecera;
        while (referencia.Siguiente != null){
            referencia = referencia.Siguiente;
            contador++;
        }
        return contador;
    }
    private string Nombre(int pTipo,int pCodigo){
        if (pTipo == 1)
        {
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
        }
        else
        {
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
        } 
    }
    private int Precio(int pTipo,int pCodigo){
        if (pTipo == 1)
        {
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
        }
        else
        {
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
        } 
    }
}


}
