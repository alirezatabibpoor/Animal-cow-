using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Sheep : Animal, IComparable<Animal>, IEnumerable<Animal>
    {
       public static int number {  get; set; }
        List<Sheepparameter> parameters=new List<Sheepparameter>();


        public int CompareTo(Animal? other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
