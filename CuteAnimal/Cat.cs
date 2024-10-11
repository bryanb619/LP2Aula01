using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        private string  _name;
        private int     _energy;
        private Mood    _moodStatus; 
        private Feed    _feedStatus;


        public Cat(string name, int energy, Mood moodState, Feed feedState)
        {
            _name       = name;
            _energy     = energy;
            _moodStatus = moodState;
            _feedStatus = feedState;
        }


        // 1st contructor


        // 2nd contructor


        // 3rd contructor
    }
}