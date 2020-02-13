using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    class Mission
    {
        private string name;
        private DateTime launchDate;
        private DateTime returnDate;
        private List<Astronaut> astronauts = new List<Astronaut>();
        private string spaceship;

        public Mission(string name, DateTime launchDate, DateTime returnDate, string spaceship)
        {
            this.name = name;
            this.launchDate = launchDate;
            this.returnDate = returnDate;
            this.spaceship = spaceship;
        }

        public string GetName()
        {
            return this.name;
        }
        public bool AddAstronaut(Astronaut astronaut)
        {
            astronaut.addDays(this.getDaysInSpace());
            astronauts.Add(astronaut);
            return true;
        }
        public string ShowInfo()
        {
            return $"{this.name} - {this.launchDate} - {this.returnDate} - {this.spaceship}: {{{this.getAstronautsName()}}}";
        }
        private string getAstronautsName()
        {
            string names = "";
            foreach (var a in astronauts)
            {
                names += (a.GetName() + ", ");
            }
            return names;
        }
        public int getDaysInSpace()
        {
            int days = (returnDate - launchDate).Days + 1;
            return days;
        }
        public List<Astronaut> GetAstronauts()
        {
            return this.astronauts;
        }
    }
}
