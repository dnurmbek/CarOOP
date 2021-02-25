using System;

namespace CarOOP
{
    class Program
    {
        class Car
        {
            private string mark;
            private string model;
            private string regNr;
            private string color;
            private int odometer;
            private int fuelTank;


            public Car(string _mark, string _model, string _regNr, string _color)
            {
                mark = _mark;
                model = _model;
                regNr = _regNr;
                color = _color;
                odometer = 0;
                fuelTank = 60;
            }
            public void Drive()
            {
                odometer += 100;
                fuelTank -= 5;
            }

            public void StopDriving()
            {
                Console.WriteLine("Out of fuel.");
            }
            public void DisplayCarInfo()
            {
                Console.WriteLine($"Mark: {mark}\nModel: {model}\nRegistration number: {regNr}" +
                    $"\nColor: {color}\nOdometer shows {odometer}\nFuel tank has {fuelTank}l left\n");

            }
            public string Mark
            {
                get { return mark; }
            }
            public string Model
            {
                get { return model; }
            }
            public string RegNr
            {
                get { return regNr; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }

            public int FuelTank
            {
                get { return fuelTank; }
            }

        }
        static void Main(string[] args)
        {
            Car auto1 = new Car("Toyota", "Supra", "2345678", "black");
            auto1.DisplayCarInfo();
            while (auto1.FuelTank != 0)
            {
                auto1.Drive();
                auto1.DisplayCarInfo();

            }
            auto1.StopDriving();
        }
    }
}
