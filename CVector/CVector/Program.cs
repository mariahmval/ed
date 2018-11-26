using System;

namespace CVector
{
    class Vector
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int BinarySearch(int[] v, int x) {

            int menor = 0;
            int mayor;
            int posicionActiva = v.Length / 2;

            if (v.Length > 0)
                mayor = v.Length - 1;
            else
                return -1;

            while (v[posicionActiva] != x && mayor > menor) {
                if (v[posicionActiva] > x)
                    mayor = posicionActiva - 1;
                else
                    menor = posicionActiva + 1;

                posicionActiva = (mayor - menor) / 2 + menor;
            }

            if (v[posicionActiva] == x)
                return posicionActiva;
            else
                return -1;
        }

    }
}
