using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class Line
    {
        List<Station> stations;
        string name;
        string color;

        public Line(string name, string color)
        {
            this.name = name;
            this.color = color;

            this.stations = new List<Station>();
        }
        public Station GetStation(string name)
        {
            foreach (Station station in this.stations)
            {
                if (name == station.GetName())
                {
                    return station;
                }
            }
            return null;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void AddStation(string name)
        {
            Station station = new Station(name);
            stations.Add(station);
        }
        public void AddStation(string name, List<Station> transfers)
        {
            Station station = new Station(name, transfers);
            stations.Add(station);
        }
        public Station RemoveStation(string name)
        {
            Station station = this.GetStation(name);
            if (station != null)
            {
                stations.Remove(station);
            }
            return station;
        }
        public Station FindStationByName(string name)
        {
            foreach (Station station in this.stations)
            {
                if (name == station.GetName())
                {
                    return station;
                }
            }
            return null;
        }
        public List<Station> GetStationList()
        {
            return this.stations;
        }
    }
}
