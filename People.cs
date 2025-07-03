using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalymovPV_01_08
{
    public class People
    {
        public int Height { get; set; } //Высота

        public int Year { get; set; }//Год рождения

        public int Weight { get; set; }//Вес

       public string P { get; set; }//Конечная цель fit или fat


        public virtual bool IsValidHeight()
        {
            return Height >= 0;
        }

        public virtual bool IsValidP()
        {
            if(P=="fit"||P=="fat")
            {
                return true;
            }else
            {
                return false;
            }
        }
        public virtual double CalculateQ()
        {
            if (Weight <= 0||Year<=0)
            {
                throw new InvalidOperationException("Вес, год, рост не могут быть меньше 0");
            }

           return  (Height * 1.8) - (Year * 4.7) + (Weight * 9.6) + 1255; //Формула Q качевство обьекта класса родителя
        }

    }

}
