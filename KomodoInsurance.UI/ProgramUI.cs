using KomodoInsurance.POCOS;
using KomodoInsurance.Repositorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.UI
{

    public class ProgramUI
    {
        private readonly DeveloperRepo _DeveloperRepo = new DeveloperRepo();
        private readonly DevTeamRepo _DevTeamRepo = new DevTeamRepo();
        private bool isSucceful;
        public void Run()
        {
            RunApplication();
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the KomodInsurance\n " + "1.Create Developer\n" +
                "2.View All Developers\n" +
                "3.Creat DevTeam\n" +
                "4.View All DevTeam\n" +
                "5.Delete Developer\n" +
                "99.Close Application");
        }
        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Menu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreatDevelpoer();
                        break;
                    case "2":
                        ViewAllDvelopers();
                        break;
                    case "3":
                        CreatDevelpoer();
                        break;
                    case "4":
                        ViewAllDevTeam();
                        break;
                    case "6":
                        DeleteDeveloper();
                        break;
                    case "99":
                        isRunning = false;
                        break;
                    default:
                        break;


                }
            }
        }

        private void DeleteDeveloper()
        {
            throw new NotImplementedException();
        }

        private void CreatDevTeam()
        {
            Console.Clear();
            _DeveloperRepo.GetDevelopers();

            Console.WriteLine("please input the TeamName");
            string userinputTeamName = Console.ReadLine();

            Console.WriteLine("please input the TeamID");
            int userInputDevId = int.Parse(Console.ReadLine());

            Developer dev =  _DeveloperRepo.GetDeveloperByIdNumber(userInputDevId);

            DevTeam devTeamToBeAddedToDataBase = new DevTeam(userinputTeamName, userInputDevId);
            _DevTeamRepo.CreateDevteam(dev);


        }

        private void ViewAllDevTeam()
        {
            Console.Clear();
            List<Developer> DevTeam = _DevTeamRepo.GetDevTeam();
            foreach (var Developer in DevTeam)
            {
               
            }
            Console.ReadKey();
        }

        private void DisplayDevTeamInfo(DevTeam devTeam)
        {
            Console.WriteLine($"{devTeam.TeamName}\n" +
                $"{devTeam.TeamID}\n" +
                $"{devTeam.TeamMember}\n");
            Console.WriteLine("**************");
        }

        private void ViewAllDvelopers()
        {
            Console.Clear();
            List<Developer> developers = _DeveloperRepo.GetDevelopers();
            foreach (var developer in developers)
            {
                DisplayDeveloperInfo(developer);
            }
            Console.ReadKey();
        }

        private void DisplayDeveloperInfo(Developer developer)
        {
            Console.WriteLine($"{developer.Name}\n " +
                $"{developer.IdNumber}\n " +
                $"{developer.HasPluralsight}");
            Console.WriteLine("****************");
        }

        private void CreatDevelpoer()
        {
            Console.Clear();

            Console.WriteLine("please input the developer's Name: ");
            string userInputName = Console.ReadLine();

            Console.WriteLine("pleas input the Developer's IdNumber: ");
            int userInputIdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("pleas input the Developer's HasPluralsight");
            bool userInputHasPluralsight = bool.Parse(Console.ReadLine());

            Developer developerToBeAddedToDataBase = new Developer(userInputName, userInputIdNumber, userInputHasPluralsight);

            _DeveloperRepo.CreateDeveloper(developer: developerToBeAddedToDataBase);
            if (isSucceful)
            {
                Console.WriteLine($"{userInputName} was successfully added to the database");
            }
            else
            {
                Console.WriteLine($"{userInputName} was not added to the dabase");
            }

        }
    }
}
