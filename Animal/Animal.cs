using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        DateTime BirthData { get; init; }
        float weight { get; set; }
        bool gender { get; set; }
        string name { get; set; }
        static readonly int MaxLife;
        List<Enviorment> EnviormentList = new List<Enviorment>();
        Healthparameter<float> healthparameter = new Healthparameter<float>();
       
       
        public float Stressfactor()
        {                   
           return healthparameter.Stressfactor();
        }
        public int Life()
        {
            return BirthData.Year;
        }
        public int timetodeath()
        {
            int death = BirthData.Year + 22;

            return death;
        }
        public float Killpriority()
        {
            float deathweight = new float();
            if( deathweight > 1200)
            {
                return (float)deathweight;

            }
            return (float)weight;

        }
        public int costperday()
        {
            int meatprice = 120000000;
            return (int)weight * meatprice;
        }
        public int valueperday()
        {
            int eachday = 500;
            return costperday() * eachday;
        }
          
    }
}
