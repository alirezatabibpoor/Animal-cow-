using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class cowparameter
    {
        DateOnly date = new DateOnly();
        Healthparameter<int> Timetostand;
        Healthparameter<int> Timetodeal;
        Healthparameter<int> Timetorelax;
        Healthparameter<int> Numberofmeal ;
        Healthparameter<int> Numberofmilkproduction;
        public override string ToString()
        {
            return $" Environment info s = \n time to stand:{Timetostand}\n time to deal:{Timetodeal}\n time to relax:{Timetorelax}\n number of meal:{Numberofmeal}\n number of milk production :{Numberofmilkproduction}";
        } 
    }
}
