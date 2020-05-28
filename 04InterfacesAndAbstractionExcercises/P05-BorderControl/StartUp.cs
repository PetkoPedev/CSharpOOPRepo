using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input;

            List<ILivable> subject = new List<ILivable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens.Length == 2)
                {
                    Robot robot = new Robot(tokens[0], tokens[1]);
                    subject.Add(robot);
                }
                else if (tokens.Length == 3)
                {
                    Human human = new Human(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    subject.Add(human);
                }
            }
            string ending = Console.ReadLine();

            foreach (ILivable subj in subject.Where(s => s.Id.EndsWith(ending)))
            {
                Console.WriteLine(subj.Id);
            }
        }
    }
}
