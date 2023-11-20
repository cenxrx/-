using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using задачки;

namespace задачки
{
    internal class Tison: People
    {
        public Tison(string imya, int uron, string opisanie, int hP, bool alive, int stamina, int iQ, int maxStamina, int MaxHP)
           : base(imya, uron, opisanie, hP, alive, stamina, iQ, maxStamina, MaxHP)
        {
        }
        public Tison() : base("MikeTison", 250, "Легендарный боксер,Чемпион в тяжелом весе", 1000, true, 300, 100, 300, 1000) { }
    }
}
   