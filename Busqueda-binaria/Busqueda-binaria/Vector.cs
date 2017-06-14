using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_binaria
{
    class Vector
    {
        private int[] vector;
        private static Random numbers;

        public Vector(int size)
        {
            vector = new int[size];
        }

        public void llenarVector(int limit)
        {
            numbers = new Random();
            for (int i = 0; i <= vector.Length - 1; i++)
                vector[i] = numbers.Next(0, limit - 1);
        }

        public string mostrar()
        {
            string contenidoVector = "";

            for (int i = 0; i <= vector.Length - 1; i++)
                contenidoVector += vector[i] + " ";

            return contenidoVector;
        }

        public void ordenar()
        {
            Array.Sort(vector);
        }

        public int busquedaBinaria(int search)
        {
            int encontrado = -1;
            int inicioVector = 0;
            int finVector = vector.Length - 1;
            int mitadVector = 0;

            while (inicioVector <= finVector && encontrado == -1) 
            {
                mitadVector = (inicioVector + finVector) / 2;

                if (vector[mitadVector] == search)
                    encontrado = mitadVector;
                if (vector[mitadVector] < search)
                    inicioVector = mitadVector + 1;
                else
                    finVector = mitadVector - 1;
            }

            return encontrado;
        }
    }
}
