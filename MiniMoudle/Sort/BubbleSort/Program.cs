using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{2, 11, 9, 1, 89, 7, 6, 2};
            Program p = new Program();
            int[] sort_arr = p.bubbleSort(arr);
            foreach (int item in sort_arr){
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        public int[] bubbleSort(int[] arr){
            int len = arr.Length;
            int i, j, med;
            for (i = 0; i < len - 1; i++){
                for(j = 0; j < len - i - 1; j++){
                    if (arr [j] > arr [j + 1]){
                        med = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = med;
                    }
                }

            }
            return arr;
        }
    }
}
