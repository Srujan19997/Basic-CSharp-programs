using System;

namespace SortingTechniques
{
    class Program
    {
         static int len;
        static int[] arr;

        static void Main(string[] args)
        {
            string userInput;

            Console.Write("Enter the size of array : ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            len = Convert.ToInt32(userInput);
            //Console.WriteLine("You entered {0}", intVal);
            arr = new int[len];



            Console.Write("Enter {0}  values  : ",len);

            for (int i = 0; i < len; i++)
            {
                userInput = Console.ReadLine();

                /* Converts to double type */
               arr[i] = Convert.ToInt32(userInput);
            }
            Program obj = new Program();
            while (true)
            {
                Console.WriteLine("----MENU----");
                Console.WriteLine("Please select your choice:\n 1:Bubble Sort \n 2:Selection Sort \n 3:Insertion Sort  \n 4:Quick Sort \n 5:Exit\n ");
                userInput = Console.ReadLine();
                int option = int.Parse(userInput);
                switch (option)
                {
                    case 1:
                        obj.bubbleSort(arr);
                        printArray();
                        break;
                    case 2:
                        obj.selectionSort(arr);
                        printArray();
                        break;
                    case 3:
                        obj.insertionSort(arr);
                        printArray();
                        break;
                    case 4:
                        Console.WriteLine(" Quick sort method");
                        obj.QuickSort(0, arr.Length-1);
                        printArray();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;


                }
            }


        }
        public  void bubbleSort(int[] arr)
        {
            Console.WriteLine(" Bubble sort method");
            for (int i = 0; i < arr.Length;i++)
            {

                for (int j = 0; j < arr.Length - 1;j++)
                {

                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

           
        }
        public void selectionSort(int[] arr)
        {
            Console.WriteLine(" Selection sort method");
            for (int i = 0; i < arr.Length;i++)
            {
                int min = i;

                for (int j = i; j < arr.Length;j++)
                {
                    if(arr[min]>arr[j])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }
        public void insertionSort(int[] arr)
        {
            Console.WriteLine(" Insertion sort method");

            for (int i = 0; i < arr.Length;i++)
            {
                int temp = arr[i];
                int j = i;
                while(j>0&&temp<arr[j-1])
                {
                    arr[j] = arr[j - 1];
                    j = j - 1;
                }
                arr[j] = temp;

            }
        }
        public void QuickSort(int lowerIndex,int higherIndex)
        {

            int i = lowerIndex;
            int j = higherIndex;
            int pivot = arr[lowerIndex + (higherIndex - lowerIndex) / 2];
            while(i<=j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if(i<=j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }

            }
            if (lowerIndex < j)
                QuickSort(lowerIndex, j);
            if (i < higherIndex)
                QuickSort(i, higherIndex);

            
        }

        public static void  printArray()
        {

            foreach (int a in arr)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();

            Console.WriteLine("---------------");

        }



    }






    }

