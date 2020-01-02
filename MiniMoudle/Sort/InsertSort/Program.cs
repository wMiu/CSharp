using System;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = new int[]{2, 5, 1, 7, 9, 3};
            int[] sort_arr = p.insertSort(arr);
            foreach (int i in sort_arr){
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

        }
        public int[] insertSort(int[] arr){
            int len = arr.Length;
            int i, j, now;
            for (i = 1; i < len; i++){
                j = i - 1;
                now = arr[i];
                while (j >= 0){
                    if (now < arr[j]){
                        arr[j + 1] = arr[j];
                        j--;
                    } else {
                        break;
                    }
                }
                arr[j + 1] = now;
            }
            return arr;
        }
    }
}
