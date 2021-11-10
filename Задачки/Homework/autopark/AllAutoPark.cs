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
    public class PassengerCar : Car
    {
        protected int passengers;
        protected Dictionary<string, int> fitches;
        public PassengerCar(string label, int power, int year, int passengers, Dictionary<string, int> fitches) : base(label, power, year)
        {
            this.passengers = passengers;
            this.fitches = fitches;
        }
        public void AddDeteil(string name, int year)
        {
            fitches.Add(name, year);
        }
        public int GetYear(string name)
        {
            return (fitches[name]);
        }
        public void PrintDeteils()
        {
            foreach (KeyValuePair<string, int> h in fitches)
            {
                Console.WriteLine("Deteil " + h.Key + " Year " + h.Value);
            }
        }
        public override string ToString()
        {
            return label + " " + power + " " + year + " " + passengers;
        }
    }
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
        public void AddMas(string name, int weight)         //добавляем массив
        {
            mas.Add(name, weight);
        }   
        public void RemoveMas(string name, int weight)      // удаляем
        {
            mas.Remove(name, out weight);
        }
        public void PrintMas()              //вывод
        {
            foreach (KeyValuePair<string, int> h in mas)
            {
                Console.WriteLine("Product name: " + h.Key + " Product weight: " + h.Value);
            }
        }
        public override string ToString()
        {
            return label + " " + power + " " + year + " " + maxmas + " " + drivername;
        }
    }
    class Autopark
    {
        protected string name;
        protected List<PassengerCar> passengerCars;
        protected List<Truck> trucks;
        public Autopark(string name, List<PassengerCar> passengerCars, List<Truck> trucks)
        {
            this.name = name;
            this.passengerCars = passengerCars;
            this.trucks = trucks;
        }
        public string PrintInfo()
        {
            string str = "";
            for (int i = 0; i < passengerCars.Count; i++)
            {
                str += passengerCars[i].ToString();
                str += " ";
            }
            for (int j = 0; j < trucks.Count; j++)
            {
                if (j == trucks.Count)
                {
                    str += trucks[j].ToString();
                }
                else
                {
                    str += trucks[j].ToString();
                    str += " ";
                }
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
