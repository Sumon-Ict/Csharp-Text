using System;

namespace codeforce_632C
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];

            for(int i=0;i<n;i++)
            {

                string str = Console.ReadLine();
                arr[i] = str;

            }



            string r = getstring(arr,n);
            Console.WriteLine(r);




        }

        static string getstring(string[] array,int n)
        {
           // int n = array.Length;


            for(int i=0;i<n-1;i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((array[i] + array[j]).CompareTo(array[j] + array[i]) > 0)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }         
                            
            }

            string str = "";
            foreach(string s in array)
            {
                str += s;
            }
            return str;

        }

        
    }
}
