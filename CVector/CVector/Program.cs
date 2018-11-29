using System;

namespace CVector
{
    class Vector
    {

        public static int BinarySearch(int[] v, int x) {

            int menor = 0;
            int mayor = v.Length - 1;
            int posicionActiva = (menor + mayor) / 2;

            if (mayor < 0)
                return -1;

            while (v[posicionActiva] != x && mayor > menor) {
                if (v[posicionActiva] > x)
                    mayor = posicionActiva - 1;
                else
                    menor = posicionActiva + 1;

                posicionActiva = (menor + mayor) / 2;
            }

            if (v[posicionActiva] == x)
                return posicionActiva;

            return -1;

            //int count = v.Length;
            //if (count == 0)
            //    return -1;
            //int left = 0;
            //int right = count - 1;
            //int middle = (left + right) / 2;
            //while (left < right && v[middle] != x) {
            //    if (v[middle] < x)
            //        left = middle + 1;
            //    else
            //        right = middle - 1;
            //    middle = (left + right) / 2;
            //}

            //return -2;

        }

    }
}
