using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repositorie
{
     public class DevTeamRepo
    {
        private readonly List<DevTeam> _DevTeam;
        private int count;

        public DevTeamRepo()
        {
            _DevTeam = new List<DevTeam>();
        }

        //C
        public bool CreateDevteam(DevTeam Team)
        {
             Team = new DevTeamRepo();

        }
        public List<DevTeam> GetDevTeam()
        {
            return _Developers;
        }
        public void AddDeveloper(DevTeam Teamr)
        {

        }
        public void RemoveDevlopers(DevTeamr Team)
        {

  
    }
}
