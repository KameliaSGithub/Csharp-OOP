using System;
using System.Collections.Generic;

namespace randomList
{
    public class StartUp
    {
        public static void Main()
        {
            RoboticRandomList roboList = new RoboticRandomList();
            roboList.Add("servo");
            roboList.Add("sensor");
            roboList.Add("actuator");
            roboList.Add("controller");

            Console.WriteLine("Removed part: " + roboList.ExtractRandomPart());
            Console.WriteLine("Remaining robotic parts:");
            foreach (var part in roboList)
            {
                Console.WriteLine(part);
            }
        }
    }

    public class RoboticRandomList : List<string>
    {
        private Random randomizer = new Random();

        public string ExtractRandomPart()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Robotic part list is empty.");
            }

            int index = randomizer.Next(0, this.Count);
            string selectedPart = this[index];
            this.RemoveAt(index);
            return selectedPart;
        }
    }
}