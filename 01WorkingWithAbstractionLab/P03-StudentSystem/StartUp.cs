using System;

namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                studentSystem.ParseCommand();
            }
        }
    }
}
