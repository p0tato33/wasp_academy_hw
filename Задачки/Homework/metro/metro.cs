using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    public class Metro
    {
        List<Line> lines;
        string city;

        public Metro(string city)
        {
            this.city = city;
            lines = new List<Line>();
        }
        public string GetCity()
        {
            return city;
        }
        public Line FindLine(string name)
        {
            foreach (Line line in this.lines)
            {
                if (name == line.GetName())
                {
                    return line;
                }
            }
            return null;
        }
        public void AddLine(string name, string color)
        {
            Line line = new Line(name, color);
            lines.Add(line);
        }
        public Line RemoveLine(string name)
        {
            Line line = this.FindLine(name);
            if(line != null)
            {
                lines.Remove(line);
            }
            return line;
        }
        public Station FindStation(string name, string lineName)
        {
            Line line = this.FindLine(lineName);
            Station station = line.FindStationByName(name);
            return station;
        }
        public List<Station> GetStationList()
        {
            foreach(Line line in lines)
            {
                return line.GetStationList();
            }
            return null;
        }
    }
}
