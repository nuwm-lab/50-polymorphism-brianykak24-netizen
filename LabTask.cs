using System;

namespace LabWork
{
    public static class LabTask
    {
        public static void Execute()
        {
            Console.WriteLine("1. Ellipsoid \n2. Sphere\n");
            int choice;

            while (true)
            {
                Console.Write("Enter choice >> ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && (choice == 1 || choice == 2))
                {
                    break;
                }

                Console.WriteLine("Incorrect input. Please enter 1 or 2.");
            }
            try
            {

                switch (choice)
                {
                    case 1:
                        Ellipsoid ellipsoid = new Ellipsoid(); 
                        ellipsoid.FillData();
                        Console.WriteLine(ellipsoid.ToString());
                        Console.WriteLine($"Volume of Ellipsoid: {ellipsoid.GetVolume()}");
                        break;
                    case 2:
                        Sphere sphere = new Sphere(); 
                        sphere.FillData();
                        Console.WriteLine(sphere.ToString());
                        Console.WriteLine($"Volume of Sphere: {sphere.GetVolume()}");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during calculation: " + e.Message);
            }
        }
    }
}
