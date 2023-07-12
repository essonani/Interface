using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public double EngineSize { get;set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public int SeatCount { get; set; }
    }
}
