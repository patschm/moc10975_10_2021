using System;

namespace Sorteren
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorteren();
        }

        static void Sorteren()
        {
            int[] data = new int[6] { 3, 7, 4, 9, 2, 5 };
            ShowData(data);


            bool isSwapped;
            do
            {
                isSwapped = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        int tmp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = tmp;
                        isSwapped = true;
                    }
                }
            }
            while (isSwapped);
            ShowData(data);
        }

        static void ShowData(int[] data)
        {
            for(int idx = 0; idx < data.Length; idx++)
            {
                int nr = data[idx];
                Console.Write(nr);
                if (idx < data.Length - 1)
                {
                    // Laatse element hoeft geen komma achter
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
