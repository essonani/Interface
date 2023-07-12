using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck:IVehicule,ICompany
    {
        public Truck() { }



        public double EngineSize { get; set; } = 6;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = ":f150";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Build Tough";
        public bool HasChangedGears { get; set; } = true;
        public bool Has4WheelDrive { get; set; } = true;

        public void Drive()
        {
            if (Has4WheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward ");
            }
            else
            {
                Console.WriteLine($" {GetType().Name} now driving forward ");

            }
        }



        public void Reverse()
        {
            bool HasChangedGears = false;
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving backward ");
                HasChangedGears = false;
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
                              
   
                                                                                                              
    

    


