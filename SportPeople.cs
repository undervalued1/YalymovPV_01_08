using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalymovPV_01_08
{
    public class SportPeople:People
    {
        public double CalculateQp()  //Формула Qp качевство обьекта класса потомка
        {
            double q = CalculateQ(); // Высчитаваем Q через родителя для дальнецших расчетов

            if(!IsValidHeight())
            {
                throw new InvalidOperationException("Рост не может быть меньше 0");
            }
            
            if(!IsValidP())
            {
                throw new InvalidOperationException("Значение цели должно быть либо fit fat");
            }
            double qp;
            if(P=="fit")
            {
                qp = q - 600; return qp;
            }
            else if(P=="fat")
            {
                qp = q + 900; return qp;
            }

            return 0;
            
        }
    }
}
