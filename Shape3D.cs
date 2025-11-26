using System;

namespace LabWork
{
    public abstract class Shape3D
    {
        private double _x1, _x2, _x3, _b1, _b2, _b3;

        public double X1 => _x1;
        public double X2 => _x2;
        public double X3 => _x3;
        public double B1 => _b1;
        public double B2 => _b2;
        public double B3 => _b3;

        public Shape3D(double x1, double x2, double x3, double b1, double b2, double b3)
        {
            this._x1 = x1;
            this._x2 = x2;
            this._x3 = x3;
            this._b1 = b1;
            this._b2 = b2;
            this._b3 = b3;
        }

        public abstract double GetVolume();
        public abstract override string ToString();

        public virtual void FillData()
        {
            Console.WriteLine("--- Entering Shape3D Base Data ---");

            _x1 = GetDoubleInput("Enter X1 (Coordinate X) >>> ");
            _x2 = GetDoubleInput("Enter X2 (Coordinate Y) >>> ");
            _x3 = GetDoubleInput("Enter X3 (Coordinate Z) >>> ");

            _b1 = GetDoubleInput("Enter B1 (Center X) >>> ");
            _b2 = GetDoubleInput("Enter B2 (Center Y) >>> ");
            _b3 = GetDoubleInput("Enter B3 (Center Z) >>> ");
        }

        protected double GetDoubleInput(string prompt)
        {
            Console.WriteLine(prompt);
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine($"Invalid input. Please enter a valid number. ({prompt})");

            }
            return value;
        }

        protected double GetPositiveDoubleInput(string prompt)
        {
            double value;
            do
            {
                value = GetDoubleInput(prompt);
                if (value > 0)
                {
                    return value;
                }
                Console.WriteLine("Error: The value must be positive (greater than 0).");
            } while (true);
        }
    }
}
