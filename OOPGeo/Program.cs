using System;

namespace OOPGeo
{
    class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
             Country country = new Country();

            int test1 = GetPopulation(country);

            int test = GetPopulation(state);

        }

        public static int GetPopulation(Country country) //POLYMORPHISM
        {
            return country.Population;
        }

        public static int GetPopulation(State state)    //POLYMORPHISM
        {
            return state.Population;
        }
    }
}
