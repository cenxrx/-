using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачки
{
    internal class Alvin : People
    {
        public Alvin(string imya, int uron, string opisanie, int hP, bool alive, int stamina, int iQ, int maxStamina, int MaxHP)
            : base(imya, uron, opisanie, hP, alive, stamina, iQ, maxStamina, MaxHP)
        {
        }
        public Alvin() : base("Alvin Perfilev", 100, "Простой парень(я)", 0, true, 100, 148, 100 , 500) { }

        //      public Alvin(string imya, int age, int hP, bool alive, int uron) : base(imya, age, hP, alive, uron)
        //{
        //}
        //public Alvin() : base("Alvin Perfilev", 17, 500, true, 100) { }
        public void SpezUdar(People people)
        {
            Console.WriteLine("Подготовка");
                Console.WriteLine("3 2 1");
                    Console.WriteLine("Удар");
            
            if (Alive) 
            {
                Stamina -= 10;
                people.HP = people.HP - Uron * 2; 
            }
        }
        
        //public Alvin("alvin", "ds,sdskf", 17, 108, "xye", 21, true, 100)
        //{
           
        //}


    }
}
