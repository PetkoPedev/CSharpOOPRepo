using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;

            List<IBirthable> creatures = new List<IBirthable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string creature = tokens[0];

                switch (creature)
                {
                    case "Citizen":
                        string citizenName = tokens[1];
                        int age = int.Parse(tokens[2]);
                        string id = tokens[3];
                        string birthdate = tokens[4];
                        Human human = new Human(citizenName, age, id, birthdate);
                        creatures.Add(human);
                        break;
                    case "Robot":
                        string robotModel = tokens[1];
                        string robotId = tokens[2];
                        Robot robot = new Robot(robotModel, robotId);
                        creatures.Add(robot);
                        break;
                    case "Pet":
                        string petName = tokens[1];
                        string petBirthdate = tokens[2];
                        Pet pet = new Pet(petName, petBirthdate);
                        creatures.Add(pet);
                        break;
                    default:
                        break;
                }
            }
            string date = Console.ReadLine();
            
        }
    }
}
