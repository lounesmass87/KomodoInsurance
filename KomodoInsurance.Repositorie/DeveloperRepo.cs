using KomodoInsurance.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repositorie
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _Developers = new List<Developer>();
      
        //C
        public void CreateDeveloper(Developer developer)
        {
            _Developers.Add(developer);
        }

        //R
        public List<Developer> GetDevelopers() 
        {
            return _Developers;
        }

        //update
        public void AddDeveloper(Developer devloper) 
        {

        }

        //Delete
        public void RemoveDevlopers(Developer developer) 
        {

        }
    }
}
