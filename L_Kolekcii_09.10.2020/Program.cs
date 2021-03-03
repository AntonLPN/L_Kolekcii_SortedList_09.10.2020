using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Kolekcii_09._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList dict_eng = new SortedList();

            dict_eng.Add("Украина", "Ukraine");
            dict_eng.Add("Америка", "America");
            dict_eng.Add("Франция", "France");
         
          
            string str = "Привет";
          
            


            Console.Write("Выберите язык перевода\n 1-С Русского на Англиский\n 2-С Английского на Русский\n>>");
            int choise = 0;
            choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("Русско - Английский словарь");
                        Console.Write("Введите страну на русском для ее перевода >>");
                        string str1 = Console.ReadLine();
                        int index_ru = 0;
                        bool match = true;
                        foreach (var item in dict_eng.Keys)
                        {

                            //Console.WriteLine(item);
                            if (str1 == item.ToString())
                            {
                                match = false;
                                Console.WriteLine(dict_eng.GetByIndex(index_ru));
                            }
                            index_ru++;
                        }

                        if (match)
                        {
                            Console.WriteLine("Перевод невозможен.Данная страна отсутствует в словаре");
                        }

                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Англо - Русский словарь");

                        int index = 0;
                        Console.Write("Введите страну на Английском для ее перевода >>");
                        string str1 = Console.ReadLine();
                        foreach (var item in dict_eng.Values)
                        {

                            //Console.WriteLine(item);
                            if (str1 == item.ToString())
                            {
                                Console.WriteLine(dict_eng.GetKey(index));
                            }
                            index++;
                        }
                        if (index == 0)
                        {
                            Console.WriteLine("Перевод невозможен.Данная страна отсутствует в словаре");
                        }
                    }
                    break;



                default:
                    if (choise!=1 && choise!=2)
                    {
                        Console.WriteLine("Ошибка ввода выбора");
                    }
                    break;
            }


        }
    }
}
