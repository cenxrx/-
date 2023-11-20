using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace задачки
{
    internal class People
    {
        public string Imya;
        public int Uron;
        public int IQ; 
        public int HP;  
        public int Stamina;
        public int MaxStamina;
        public int MaxHP;
        public string Opisanie;
        public bool Alive = true;
      
        

        public People(string imya, int uron, string opisanie, int hP, bool alive, int stamina, int iQ, int maxStamina, int maxHP)
        {
            Imya = imya;
            Uron = uron;
            Opisanie = opisanie;
            HP = hP;
            Alive = alive;
            Stamina = stamina;
            IQ = iQ;
            MaxStamina = maxStamina;
            MaxHP = maxHP;
            //добавить мах хп
        }


        //public People(string imya, int age, int hP, bool alive, int uron)
        //{
        //    Imya = imya;
        //    Age = age;
        //    HP = hP;
        //    Alive = alive;
        //    Uron = uron;
        //}
        public void MaxHeath()
        {
            if (Alive) 
            {
                MaxHP = HP;
            }
        }

        public void Show()
        {
            if(Alive== true) 
            { 
            Console.WriteLine("Статус: Жив " + Alive );
            Console.WriteLine("Имя Бойца: "+Imya);
            Console.WriteLine("Урон: " + Uron);
            Console.WriteLine("Описание бойца: " + Opisanie);
            Console.WriteLine("Здоровье: " + HP );            
            Console.WriteLine("Выносливость: " + Stamina);
                return;
            }
            else
            Console.WriteLine("Статус: МЕРТВ " + Alive);
            Console.WriteLine("Имя Бойца: " + Imya);
            Console.WriteLine("Урон: " + Uron);
            Console.WriteLine("Описание бойца: " + Opisanie);
            Console.WriteLine("Здоровье: " + HP);
            Console.WriteLine("Выносливость: " + Stamina);
            return;
        }
        public bool IsAlive()
        {
            if (HP <= 0)
            {
                Console.WriteLine("мертв");
                return false;
            }

            else
            {
                Console.WriteLine("ЖИВ");
                return true;
            }
                
        }
        public void Razum()
        {
            if (IQ >= 130) 
            {
               HP = HP*150/100;
            }

        }
        public void Punch(People people)
        {
            if (Alive) 
            {
                Stamina--;
                HP = HP - people.Uron;
                Console.WriteLine("Ударил");
            }
            else
            {
                Console.WriteLine("Мертвые не бьют");
            }
        }
        public void RegenStamin(People people)
        {
            if (Alive) 
            {
                for (int i = 0; i < 99999 ; i++)
                {
                    if (Alive)
                    {
                        if (people.Stamina == people.MaxStamina)
                        {
                            people.Stamina = people.MaxStamina;
                        }
                        else
                        {
                            Thread.Sleep(3000);
                            people.Stamina++;
                            Console.WriteLine(1);
                        }
                    }
                    else
                        Console.WriteLine("Он мертв братик");
                }
            }
        }
        
	

	}
}
    

