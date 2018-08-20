using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGeo
{
    class Location  //ENCAPSULATON
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int population { get; set; }
        public int Population
        {
            get
            {
                return population;
            }
            set                                 //Encapsulation to prevent negative vlaues for population
                                                //if user sets pop to <0, it will override to 0.  ..
            {
                if (value < 0)
                {
                    population = 0;
                }
                else
                {
                    population = value;
                }
            }
        }
    }
}
