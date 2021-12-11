using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCOS
{
    public class DevTeam
    {
        public DevTeam(string teamName, int teamID)
        {
            TeamName = teamName;
            TeamID = teamID;
        }
        public DevTeam()
        {

        }

        public List<Developer> TeamMember { get; set; } = new List<Developer>();
        public string TeamName { get; set; }
        public int TeamID { get; set; }
    }
}
