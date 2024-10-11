using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {   
        // Vars ----------------------------------------------------------------
        private string  _name;
        private int     _energy;
        private Mood    _moodStatus; 
        private Feed    _feedStatus;

        // random class 
        private Random _random; 

        // const
        private const int _maxEnergy = 100;  


        // Constructors --------------------------------------------------------


        // 1st contructor 
        private Cat()
        {

        }

        // 2nd contructor
        public Cat(string name, int energy, Mood moodState, Feed feedState) 
        : this()
        {
            _name       = name;

            // 

            if (energy <= 0) _energy = 0;

            else if (energy >= _maxEnergy) _energy = _maxEnergy;

            else { _energy = energy;} 

            _moodStatus = moodState;
            _feedStatus = feedState;
        }


        // 3rd contructor
        public Cat(string name)
        {
            //this();
        }



        // Getters -------------------------------------------------------------

        public string GetName()
        {
            return _name; 
        }

        public int GetEnergy()
        {
            return _energy;
        }
    }
}