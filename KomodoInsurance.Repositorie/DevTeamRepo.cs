using KomodoInsurance.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repositorie
{
     public class DevTeamRepo
    {
        private DevTeam _DevTeam = new DevTeam();
        private int count;

        //C
        public void CreateDevteam(Developer developer)
        {
            _DevTeam.TeamMember.Add(developer);

        }
        //R
        public List<Developer> GetDevTeam()
        {
            return _DevTeam.TeamMember;
        }
        //U
        public bool UpdateDevTeam(int teamID, DevTeam newDevTeam)
        {
            DevTeam oldDevTeam = GetDevTeamByteamID(teamID);
            if (oldDevTeam != null)
            {
                oldDevTeam.TeamID = newDevTeam.TeamID;
                oldDevTeam.TeamMember = newDevTeam.TeamMember;
                oldDevTeam.TeamName = newDevTeam.TeamName;
                return true;
            }
            else
            {
                return false;
            }
        }

        private DevTeam GetDevTeamByteamID(int teamID)
        {
            throw new NotImplementedException();
        }

        //D
        public bool RemoveDevTeamBytemID(int teamID) 
        {
            DevTeam devTeam = GetDevTeamByTeamID(teamID);
            if (devTeam == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private DevTeam GetDevTeamByTeamID(int teamID)
        {
            throw new NotImplementedException();
        }
        //Helper methode
    }
}
