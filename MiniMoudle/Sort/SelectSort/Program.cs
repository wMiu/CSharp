using System;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = new int[]{2, 11, 9, 1, 89, 7, 6, 2};
            int[] sort_arr = p.SelectSort(arr);
            foreach (int i in sort_arr){
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        public int[] SelectSort(int[] arr){
            int len = arr.Length;
            int i, j, med, min;
            for (i = 0; i < len; i ++){
                for (j = i + 1; j < len; j ++){
                    min = i;
                    if (arr[min] > arr[j]){
                        min = j;
                    }
                }
                med = arr[j];
                arr[j] = arr[i];
                arr[i] = med;
            }
            return arr;
        }
    }
}
