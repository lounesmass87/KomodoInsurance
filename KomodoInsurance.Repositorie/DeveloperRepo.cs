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
        public bool UpdateDeveloper(int idNumber, Developer newDeveloper) 
        {
            Developer oldDeveloper = GetDeveloperByIdNumber(idNumber);
            if(oldDeveloper != null)
            {
                oldDeveloper.Name = newDeveloper.Name;
                oldDeveloper.IdNumber = newDeveloper.IdNumber;
                oldDeveloper.HasPluralsight = newDeveloper.HasPluralsight;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Developer GetDeveloperByIdNumber(int idNumber)
        {
            foreach (Developer developers in _Developers)
            {
                if (idNumber == developers.IdNumber)
                {
                    return developers;
                }
            }
            return null;

        }

        //Delete
        public bool RemoveDevlopers(int idNumber)
        {
            Developer developer = GetDeveloperByIdNumber(idNumber);
            if (developer == null)
            {
                return false;
            }
            else
            {
                _Developers.Remove(developer);
                return true;
            }
        }
        //helper methode
    }
}
