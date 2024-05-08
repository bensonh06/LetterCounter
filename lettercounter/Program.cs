using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettercounter
{

    class Character
    {
        public char chr;
        public int count;

        public Character()
        {

            count = 1;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> list = new List<Character>();

            Console.Write("Enter a string: ");

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                bool found = false;

                char c = input[i];

                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].chr == c)
                    {
                        found = true;
                        list[j].count++;
                    }
                }

                if (!found)
                {
                    Character newchar = new Character();
                    newchar.chr = c;
                    list.Add(newchar);
                }

            }

            Console.WriteLine();

            for (int i = 0;i < list.Count;i++)
            {
                if (list[i].chr == ' ')
                {
                    Console.WriteLine("<> - " + list[i].count);
                } else
                {
                    Console.WriteLine(list[i].chr + " - " + list[i].count);
                }
                
            }

            Console.ReadLine();
        }
    }
}
