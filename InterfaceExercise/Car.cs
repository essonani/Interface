using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public  class Car:IVehicule , ICompany
    {
        public Car() 
        {

        }

        public double EngineSize { get; set; } = 4;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "Taurus";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "good car";
        public bool HasChangedGears { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward ");
        }

        public void Reverse()
        {
            if(HasChangedGears==true)
            {
                Console.WriteLine($"{GetType().Name} now driving backward ");
                HasChangedGears=false;
            }
            else { Console.WriteLine("cant reverse yet"); }
            
        }
        public void Park()
        {
            Console.WriteLine();
        }
        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public bool ChangeGears(bool isChanged)
        {
           return HasChangedGears = isChanged;
        }
    }
}
