using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionControl
{
    public partial class MissionControlForm : Form
    {
        private List<Astronaut> listOfAstronauts = new List<Astronaut>();
        private List<Mission> listOfMissions = new List<Mission>();
        public MissionControlForm()
        {
            InitializeComponent();    
        }

        private void btAddAstronaut_Click(object sender, EventArgs e)
        {

            string name = this.tbAstronautName.Text;
            string nationality = this.tbAstronautNationality.Text;
            Gender gender = this.toGender(this.cbAstronautGender.Text);

            if(name.Length > 0 & nationality.Length > 0)
            {
                Astronaut a = new Astronaut(name, gender, nationality);
                if (astronautValidation(a))
                {
                    this.addAstronaut(a);
                }else
                {
                    MessageBox.Show("Astronaut already exists!");
                }
            }
            else
            {
                MessageBox.Show("Invalid information!");
            }

            clearInputFields();
        }
        private void btAddMission_Click(object sender, EventArgs e)
        {
            string name = this.tbMissionName.Text;
            DateTime launchDate = this.dtpLaunchDate.Value;
            DateTime returnDate = this.dtpReturnDate.Value;
            string spaceship = this.tbSpaceship.Text;

            if(name.Length > 0 && spaceship.Length > 0)
            {

                Mission m = new Mission(name, launchDate, returnDate, spaceship);
                if (missionValidation(m))
                {
                    this.addMission(m);
                }
                else
                {
                    MessageBox.Show("Mission already exists!");
                }
            }

            clearInputFields();
        }
        private void btShowAllMissions_Click(object sender, EventArgs e)
        {
            this.lbMissions.Items.Clear();
            foreach (var m in listOfMissions)
            {
                this.lbMissions.Items.Add(m.ShowInfo());
            }
        }
        private void btAssign_Click(object sender, EventArgs e)
        {
            if(this.cbMissions.Text.Length > 0 && this.cbAstronauts.Text.Length > 0)
            {
                Mission mission = this.searchMissionByName(cbMissions.Text);
                Astronaut astronaut = this.searchAstronautByName(cbAstronauts.Text);
                bool flag = true;
                if(mission != null && astronaut != null)
                {
                    List<Astronaut> list = mission.GetAstronauts();
                    foreach (var item in list)
                    {
                        if (item.GetName() == astronaut.GetName()) flag = false;
                    }
                    if(flag)mission.AddAstronaut(astronaut);
                }
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            clearInputFields();
        }
        private void btShowAstronautDetails_Click(object sender, EventArgs e)
        {
            Astronaut astronaut = searchAstronautByName(this.cbAstronautDetails.Text);
            if (astronaut != null)
            {
                this.tbDaysInSpace.Text = astronaut.GetTotalDays().ToString();
                List<Mission> list = GetMissionOfAstronaut(astronaut);


                lbMissionHistory.Items.Clear();
                foreach (var item in list)
                {
                    lbMissionHistory.Items.Add(item.GetName());
                }

                int longestMissionDays = 0;
                Mission longestMission = null;
                foreach (var item in list)
                {
                    if (longestMissionDays < item.getDaysInSpace())
                    {
                        longestMissionDays = item.getDaysInSpace();
                        longestMission = item;
                    }

                }
                this.tbLongestMission.Text = $"{longestMission.GetName()} - {longestMissionDays} days.";

                lbTravelCompanions.Items.Clear();
                List<string> companionNames = new List<string>();
                foreach (var m in list)
                {
                    foreach (var a in m.GetAstronauts())
                    {
                        if (a.GetName() != astronaut.GetName() && !companionNames.Contains(a.GetName()))
                        {
                            companionNames.Add(a.GetName());
                            this.lbTravelCompanions.Items.Add(a.GetName());
                        }
                    }
                }


            }
        }
        private void clearInputFields()
        {
            this.tbAstronautName.Text = "";
            this.tbAstronautNationality.Text = "";
            this.tbSpaceship.Text = "";
            this.tbMissionName.Text = "";
            this.cbAstronauts.SelectedIndex = -1;
            this.cbMissions.SelectedIndex = -1;
        }



        // Astronaut
        private void addAstronaut(Astronaut astronaut)
        {
            this.listOfAstronauts.Add(astronaut);
            this.cbAstronauts.Items.Add(astronaut.GetName());
            this.cbAstronautDetails.Items.Add(astronaut.GetName());
        }
        private Gender toGender(string gender)
        {
            if (gender == "MALE")
            {
                return Gender.MALE;
            }
            return Gender.FEMALE;
        }
        private bool astronautValidation(Astronaut astronaut)
        {
            foreach (var a in listOfAstronauts)
            {
                if(a.GetName() == astronaut.GetName())
                {
                    return false;
                }
            }
            return true;
        }  
        private Astronaut searchAstronautByName(string name)
        {
            foreach (var a in listOfAstronauts)
            {
                if (a.GetName() == name) return a;
            }
            return null;
        }

        // Mission
        private void addMission(Mission mission)
        {
            this.listOfMissions.Add(mission);
            this.cbMissions.Items.Add(mission.GetName());
        }
        private bool missionValidation(Mission mission)
        {
            foreach (var m in listOfMissions)
            {
                if (m.GetName() == mission.GetName())
                {
                    return false;
                }
            }
            return true;
        }
        private Mission searchMissionByName(string name)
        {
            foreach (var m in listOfMissions)
            {
                if (m.GetName() == name) return m;
            }
            return null;
        }
        private List<Mission> GetMissionOfAstronaut(Astronaut astronaut)
        {
            List<Mission> missions = new List<Mission>();

            foreach (var m in listOfMissions)
            {
                foreach (var a in m.GetAstronauts())
                {
                    if (a.GetName() == astronaut.GetName()) { missions.Add(m); break; }
                }
            }
            return missions;
        }
    }
}
