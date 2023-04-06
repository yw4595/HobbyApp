using System;

namespace HikingApp
{
    // Author: Yanzhi Wang
    // Purpose: Base class for hiking
    // Restrictions: None
    public abstract class Hiking
    {
    }

    // Author: Yanzhi Wang
    // Purpose: Base class for hiking equipment
    // Restrictions: None
    public abstract class Equipment
    {
        private string name;
        private double weight;
        private string color;

        public abstract void Use();
    }

    // Author: Yanzhi Wang
    // Purpose: Class representing a hiking trail
    // Restrictions: None
    public class Trail
    {
        private string name;
        private double distance;
        private double elevationGain;
        private int difficultyLevel;

        public double CalculateTime()
        {
            // Calculation logic goes here
            return 0.0;
        }
    }

    // Author: Yanzhi Wang
    // Purpose: Class representing a camping site
    // Restrictions: None
    public class Campsite
    {
        private string name;
        private string location;
        private int capacity;
        private bool availability;

        public void Reserve()
        {
            // Reservation logic goes here
        }
    }

    // Author: Yanzhi Wang
    // Purpose: Interface for trail guide
    // Restrictions: None
    public interface ITrailGuide
    {
        string GetDirections();
    }

    // Author: Yanzhi Wang
    // Purpose: Interface for camping
    // Restrictions: None
    public interface ICamping
    {
        void Reserve();
    }

    // Author: Yanzhi Wang
    // Purpose: Class representing a trail guide
    // Restrictions: None
    public class TrailGuide : ITrailGuide
    {
        public string GetDirections()
        {
            // Directions logic goes here
            return "Turn left at the next junction";
        }
    }

    // Author: Yanzhi Wang
    // Purpose: Class representing camping
    // Restrictions: None
    public class Camping : ICamping
    {
        public void Reserve()
        {
            // Reservation logic goes here
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects
            TrailGuide trailGuide = new TrailGuide();
            Camping camping = new Camping();

            // Call MyMethod with each object
            MyMethod(trailGuide);
            MyMethod(camping);

            Console.ReadKey();
        }

        // Author: Yanzhi Wang
        // Purpose: Demonstrates polymorphism by calling supported methods based on object type
        // Restrictions: None
        static void MyMethod(object obj)
        {
            if (obj is ITrailGuide)
            {
                ITrailGuide trailGuide = (ITrailGuide)obj;
                Console.WriteLine(trailGuide.GetDirections());
            }

            if (obj is ICamping)
            {
                ICamping camping = (ICamping)obj;
                camping.Reserve();
            }
        }
    }
}
