using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Healthparameter<T>
    {
        const double alpha = 0.3;
        public string Name {  get; set; }
        public double Current { get; set; }
        public double standard { get; set; }
        public override string ToString()
        {
            return $"{Name}:\n current percentage= {Current}\n standard percentage= {standard}";
        }
        public float Stressfactor()
        {
            return (float)((Current/standard)*alpha);

            
            
            
        }
    }
}
