﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace TowerofHanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Hanoigame hg = new Hanoigame();

            List<char> list1 = new List<char>();
            List<char> list2 = new List<char>();
            List<char> list3 = new List<char>();


            Console.WriteLine("insert the color dice into the rod with 3 by 3 matrix ");

            for(int i=0;i<3;i++)
            {
                char[] colordice = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                 list1.Add(colordice[0]);
                list2.Add(colordice[1]);
                list3.Add(colordice[2]);


            }

            list1.Reverse();
            list2.Reverse();
            list3.Reverse();


            int d = 1;
            int list2count = list2.Count;

            for(int i=1;i<list2count;i++)
            {
                hg.movecolordice(list2, list1);
                hg.presensituation(d++,list1, list2, list3);

            }

            char  colorofdice_rod_2 = list2[0];

                while (list1.Contains(colorofdice_rod_2))
                {

                    if (colorofdice_rod_2 == list1[list1.Count-1])
                    {
                        hg.movecolordice(list1, list2);
                        hg.presensituation(d++, list1, list2, list3);
                    }
                    else
                    {
                        hg.movecolordice(list1, list3);
                        hg.presensituation(d++, list1, list2, list3);
                    }
                }




            while (list3.Contains(colorofdice_rod_2))
            {
                if (colorofdice_rod_2 == list3[list3.Count - 1])
                {
                    hg.movecolordice(list3, list2);
                    hg.presensituation(d++, list1, list2, list3);
                }
                else
                {
                    hg.movecolordice(list3, list1);
                    hg.presensituation(d++, list1, list2, list3);
                }
            }



            int list3size = list3.Count;
            for(int i=0;i<list3size;i++)
            {
                hg.movecolordice(list3, list1);
                hg.presensituation(d++, list1, list2, list3);


            }


            char colorofdice_rod3 = list1[list1.Count - 1];


            while(list1.Contains(colorofdice_rod3))
            {
                if(colorofdice_rod3==list1[list1.Count-1])
                {
                    hg.movecolordice(list1, list3);
                    hg.presensituation(d++, list1, list2, list3);

                }
                else
                {
                    hg.movecolordice(list1, list2);
                    hg.presensituation(d++, list1, list2, list3);
                }
            }



            int list2size = list2.Count-3;


            for(int i=0;i<list2size;i++)         //storing the rest of color of dice in rod_1 
            {
                hg.movecolordice(list2, list1);
                hg.presensituation(d++, list1, list2, list3);

            }


            Console.WriteLine($"success, Total try: {d-1}");

                                  
        }



    }
}
