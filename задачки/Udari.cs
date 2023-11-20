using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачки
{
    internal class Udari
    {
        public int MinDamage;
        public int MaxDamage;
        public int AttackSpeed;
        public int Accuracy;//Точность
        public int Durability = 100;//прочность кулака
        public bool Alive = true;
        public string Name;
        public float Level = 0;
    }
    //пропиши метод удары, создай класс Fight club где улучшают удары, метод состояение кулака
}
