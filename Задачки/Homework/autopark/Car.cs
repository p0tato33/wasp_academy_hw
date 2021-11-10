using System;
using System.Collections.Generic;

namespace Academy
{
    public class Car
    {
        protected string label;
        protected int power;
        protected int year;
        public Car(string label, int power, int year)
        {
            this.label = label;
            this.power = power;
            this.year = year;
        }
        public virtual string ToString()
        {
            return "";
        }
    }
