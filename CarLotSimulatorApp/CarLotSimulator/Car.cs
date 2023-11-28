using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public void MakeEngineNoise(string engineNoise)
        {
            engineNoise = EngineNoise;
            Console.WriteLine($"loud {engineNoise} coming from car");
        } 

        public void MakeHonkNoise(string honkNoise)
        {
            honkNoise = HonkNoise;
            Console.WriteLine($"loud {honkNoise} coming from car");
        }
        
        //The methods should take one string parameter: the respective noise property 


    }
}
