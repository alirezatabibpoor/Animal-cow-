using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Cow : Animal, IComparable<Animal>, IEnumerable<Animal>
    {
        
        public static int number {  get; set; }

        List<cowparameter> parameters = new List<cowparameter>();
        
          
      
        
        

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
