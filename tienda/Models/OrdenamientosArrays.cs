using System;
namespace tienda.Models
{
    public class OrdenamientosArray
    {
        private static void Swap(int[] vec, int indice1, int indice2){
            int tpm = vec[indice1];
            vec[indice1] = vec[indice2]; 
            vec[indice2] = tpm;
            }
            private static void Swapstring(string[] vec, int indice1, int indice2){
            string tpm = vec[indice1];
            vec[indice1] = vec[indice2]; 
            vec[indice2] = tpm;
            }
        public void BubbleSort(int[] vec1, string[] vec2, int[] vec3){
            int limite = 0;
            int indice = 0;
            int cantidad = vec1.Length;
            //las pases correspondientes
            for (limite = 1; limite < cantidad; limite++)
            {
                // los elementos hacia la derecha van quedando ordenados
                for (indice = 0; indice < cantidad - limite; indice++)
                {
                    //recorrer la lista verificando si hay que hacer intercambio
                    if (vec1[indice] > vec1[indice + 1])
                    {
                        Swap(vec1 , indice, indice + 1);
                        Swapstring(vec2 , indice, indice + 1);
                        Swap(vec3 , indice, indice + 1);
                    }
                }
            }
        }

        public void InsertionSort(int[] vec1, string[] vec2, int[] vec3){
            int cantidad = vec1.Length;
            int indice = 0;
            int posespacio = 0;
            int precio = 0;
            string nombre = "";
            int codigo = 0;
            
            //Recorrer los elementos
            for (indice = 1; indice < cantidad; indice++)
            {
                //obtener el dato
                precio = vec1[indice];
                nombre = vec2[indice];
                codigo = vec3[indice];
                // en que posicion se encuentra nuestro espacio
                posespacio = indice;
                //recorrer los elementos a la cajita
                while (posespacio > 0 && vec1[posespacio - 1] > precio)
                {
                    vec1[posespacio] = vec1[posespacio - 1];
                    vec2[posespacio] = vec2[posespacio - 1];
                    vec3[posespacio] = vec3[posespacio - 1];
                    posespacio = posespacio - 1;
                }
                vec1[posespacio] = precio;
                vec2[posespacio] = nombre;
                vec3[posespacio] = codigo;
            }
        }
    }
}
