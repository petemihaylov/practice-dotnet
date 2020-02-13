using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    class Astronaut
    {
        private string name;
        private Gender gender;
        private string nationality;
        private int daysInSpace;

        public Astronaut(string name, Gender gender, string nationality)
        {
            this.name = name;
            this.gender = gender;
            this.nationality = nationality;
            this.daysInSpace = 0;
        }

        public string GetName()
        {
            return this.name;
        }
        public void addDays(int days)
        {
            this.daysInSpace += days;
        }
        public int GetTotalDays()
        {
            return this.daysInSpace;
        }
    }
}
