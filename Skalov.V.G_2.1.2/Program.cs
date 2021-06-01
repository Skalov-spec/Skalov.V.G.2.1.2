
using System;

 

namespace Skalov_V_G_

{

       class Program

       {

             public static void Main(string[] args)

             {

                    int[] array = new int[] {9,6,7,8,45,3,2,1,4,5,-434,56};

                    for (int i = 0; i<array.Length; i++){

                           Console.Write(array[i] + " ");

                    }

                    Console.WriteLine("");

                    array = ArraySort(array);

                    for (int i = 0; i<array.Length; i++){

                           Console.Write(array[i] + " ");

                    }

                    Console.Write("Press any key to continue . . . ");

                    Console.ReadKey(true);

             }

            

             public static int[] ArraySort (int[] arr){

                    for (int i=0; i<arr.Length; i++){

                           int min = arr[i], ind = i;

                           for (int j = i+1; j<arr.Length; j++){

                                  if (min > arr[j]){

                                        min = arr[j];

                                        ind = j;

                                  }

                           }

                           int temp = arr[i];

                           arr[i] = arr[ind];

                           arr[ind] = temp;

                    }

                   

                    return arr;

                   

             }

       }

}
	