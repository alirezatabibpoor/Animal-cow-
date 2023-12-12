using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   public class Sheepparameter
    {
        DateOnly date = new DateOnly();
        Healthparameter<int> Timetostand {  get; set; }
        Healthparameter<int> Timetodeal { get; set; }
        Healthparameter<int> Timetorelax { get; set; }
        Healthparameter<int> Numberofmeal { get; set; }
        Healthparameter<int> Numberofmilkproduction { get; set; }
        public override string ToString()
        {
            return $" Environment info s = \n time to stand:{Timetostand}\n time to deal:{Timetodeal}\n time to relax:{Timetorelax}\n number of meal:{Numberofmeal}\n number of milk production :{Numberofmilkproduction}";
        }
    }
}
