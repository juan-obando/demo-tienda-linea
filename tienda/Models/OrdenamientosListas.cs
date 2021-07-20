using System;
namespace tienda.Models
{
    public class OrdenamientosListas
    {
        private static void Swap(ListaEnlazada lista,int indice1, int indice2){
            int tpm = lista[indice1]; //get
            lista[indice1] = lista[indice2]; //set
            lista[indice2] = tpm; //set
            // 2 4
        }
        private static ListaEnlazada Merge(ListaEnlazada listaIzquierda, ListaEnlazada listaDerecha){
            // Para que merge funcione la lista izq y la lista der deben estar ordenadas
            ListaEnlazada listaUnida = new ListaEnlazada();
            //indices de cada lista
            int indiceIzquierdo = 0;
            int indiceDerecho = 0;
            int cantidadIzquierdo = listaIzquierda.Cantidad();
            int CantidadDerecho = listaDerecha.Cantidad();
            // recorrer mientras las 2 listas tienen elementos sin procesar
            while (indiceIzquierdo < cantidadIzquierdo && indiceDerecho < CantidadDerecho)
            {
                //si el de la izq es menor o igual adicionamos al de la izq
                if (listaIzquierda[indiceIzquierdo] <= listaDerecha[indiceDerecho])
                {
                    listaUnida.Adicionar(listaIzquierda[indiceIzquierdo]);
                    indiceIzquierdo++;
                }
                else
                {
                    //der => si el de la derecha es menor o igual adicionar al de la der
                    listaUnida.Adicionar(listaDerecha[indiceDerecho]);
                    indiceDerecho++;
                }
            }
            // si sobran  elementos de la lista izq ponerlos todos
            while (indiceIzquierdo < cantidadIzquierdo)
            {
                listaUnida.Adicionar(listaIzquierda[indiceIzquierdo]);
                indiceIzquierdo++;
            }
            // si sobran  elementos de la lista der ponerlos todos
            while (indiceDerecho < CantidadDerecho)
            {
                listaUnida.Adicionar(listaDerecha[indiceDerecho]);
                indiceDerecho++;
            }
            // regresa la lista unida como resultado de merge
            return listaUnida;
        }
        public ListaEnlazada MergeSort(ListaEnlazada pLista){
            //Cantidad de elementos de la lista
            int cantidad = pLista.Cantidad();
            int n = 0; //Variable de apoyo

            //Caso base (Si es 0 o 1)
            if(cantidad < 2){
                return pLista;
            }

            //Obtener la mitad
            int mitad = cantidad/2;
            ListaEnlazada Izquierda = new ListaEnlazada();
            ListaEnlazada Derecha = new ListaEnlazada();
            //adicionamos los elementos en la lista de la izquierda
            for(n=0;n<mitad;n++){
                Izquierda.Adicionar(pLista[n]);
            }
            //adicionamos los elementos en la lista de la derecha
            for(n=mitad;n<cantidad;n++){
                Derecha.Adicionar(pLista[n]);
            }
            
            //Parte inductiva
            ListaEnlazada tmpIzquierda = MergeSort(Izquierda);
            ListaEnlazada tmpDerecha = MergeSort(Derecha);
            ListaEnlazada ordenada = Merge(tmpIzquierda, tmpDerecha);

            return ordenada;
        }
        private static int Pivote(ListaEnlazada lista,int pInicio, int pFin){
            int pivote = 0;
            int indicePivote = 0;
            int indiceComparacion = 0;
            //Seleccionamos el ultimo como pivote (promedio)
            pivote = lista[pFin];
            //indice de pivote con pInicio
            indicePivote = pInicio;
            //Indice de pivote con el indice de inicio
            for (indiceComparacion = pInicio; indiceComparacion < pFin; indiceComparacion++){
                if (lista.Precio(lista[indiceComparacion]) <= lista.Precio(pivote))
                {
                    Swap(lista, indiceComparacion, indicePivote);
                    indicePivote++;
                }
            }
            // Hacemos intercambio para colocar el pivote
            Swap(lista, indicePivote, pFin);
            
            
            return indicePivote;
        }
        public void QuickSort(ListaEnlazada lista,int pInicio, int pFin){
            int indicePivote = 0;

            // Caso base
            if (pInicio >= pFin)
            {
                return;
            }
            indicePivote = Pivote(lista, pInicio, pFin);
            // parte inductiva
            QuickSort(lista, pInicio, indicePivote - 1);
            QuickSort(lista, indicePivote + 1, pFin);
        }
    }
}