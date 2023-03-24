using System;

namespace HobbyApp
{
    // Author: Yanzhi Wang
    // Purpose: Represents a hobby activity
    // Restrictions: None
    public abstract class Hobby
    {
        public string Name { get; set; }
        public int AgeRequirement { get; set; }

        // Purpose: Abstract method for describing the hobby
        // Restrictions: None
        public abstract void Describe();

        // Purpose: Virtual method for demonstrating the hobby
        // Restrictions: None
        public virtual void DoHobby()
        {
            Console.WriteLine("Doing the hobby!");
        }
    }

    // Author: Yanzhi Wang
    // Purpose: Represents a sports hobby activity
    // Restrictions: None
    public class SportsHobby : Hobby, IOutdoorHobby
    {
        public bool RequiresTeam { get; set; }

        // Purpose: Method for describing the sports hobby
        // Restrictions: None
        public override void Describe()
        {
            Console.WriteLine("This is a sports hobby!");
        }

        // Purpose: Method for playing the sports hobby
        // Restrictions: None
        public void Play()
        {
            Console.WriteLine("Playing the sports hobby!");
        }
    }

    // Author: Yanzhi Wang
    // Purpose: Represents a music hobby activity
    // Restrictions: None
    public class MusicHobby : Hobby, IIndoorHobby
    {
        public string Genre { get; set; }

        // Purpose: Method for describing the music hobby
        // Restrictions: None
        public override void Describe()
        {
            Console.WriteLine("This is a music hobby!");
        }

        // Purpose: Method for playing the music hobby
        // Restrictions: None
        public void Play()
        {
            Console.WriteLine("Playing the music hobby!");
        }
    }

    // Author: Yanzhi Wang
    // Purpose: Represents an indoor hobby activity
    // Restrictions: None
    public interface IIndoorHobby
    {
        void Play();
    }

    // Author: Yanzhi Wang
    // Purpose: Represents an outdoor hobby activity
    // Restrictions: None
    public interface IOutdoorHobby
    {
        bool RequiresTeam { get; set; }
        void Play();
    }

    class Program
    {
        // Purpose: Entry point of the application
        // Restrictions: None
        static void Main()
        {
            SportsHobby sportsHobby = new SportsHobby
            {
                Name = "Basketball",
                AgeRequirement = 10,
                RequiresTeam = true
            };

            MusicHobby musicHobby = new MusicHobby
            {
                Name = "Guitar",
                AgeRequirement = 12,
                Genre = "Rock"
            };

            // Call the Describe() method on both hobbies
            sportsHobby.Describe();
            musicHobby.Describe();

            // Call the Play() method using the IIndoorHobby interface
            IIndoorHobby indoorHobby = musicHobby;
            indoorHobby.Play();

            // Call the Play() method using the IOutdoorHobby interface
            IOutdoorHobby outdoorHobby = sportsHobby;
            outdoorHobby.Play();
        }
    }
}
