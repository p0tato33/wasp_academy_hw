using System;
using System.Collections.Generic;

namespace Academy
{
 public class Truck : Car
    {
        protected int maxmas;
        protected string drivername;
        protected Dictionary<string, int> mas;
        public Truck(string label, int power, int year, int maxmas, string drivername, Dictionary<string, int> mas) : base(label, power, year)
        {
            this.maxmas = maxmas;
            this.drivername = drivername;
            this.mas = mas;
        }
        public void NewDriver(string name)
        {
            drivername = name;
        }
