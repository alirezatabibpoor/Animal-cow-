using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Enviorment
    {
        Healthparameter<int> TDS = new Healthparameter<int>();       
        Healthparameter<int> Temp;
        Healthparameter<int> Denisty;
        Healthparameter<int> db;
        Healthparameter <int > AQI;
        Healthparameter<int> OX;

        DateOnly data { get; set; }
        public override string ToString()
        {
            return $" Environment info s = \n TDS:{TDS}\n Temp:{Temp}\n denisty:{Denisty}\n db:{db}\n AQI:{AQI}\n OX:{OX}";
        }
       
    }
}
