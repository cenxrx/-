using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачки
{
    internal class Trener : People
    {
        public int Duh;

        public Trener(string imya, int uron, string opisanie, int hP, bool alive, int stamina, int iQ, int Duh, int maxStamina, int maxHP) 
            : base(imya, uron, opisanie, hP, alive, stamina, iQ, maxStamina, maxHP)
        {
            
        }
        
        public Trener() : base("Фредди Роуч",0 , "А******* тренер", 1, true, 1, 160, 1, 1) 
        {
            Duh = 100;
        }
        public void Reassurance(People people)
        {
            if (Alive)
            {
                if (Duh > 9)
                {
                    Duh -= 10;
                    people.HP = people.HP + 300;
                    return;
                }
                else
                {
                    Console.WriteLine("Тренер совсем не видит победы, он в тильте");
                    return;
                }
            }
        }
    }
}
