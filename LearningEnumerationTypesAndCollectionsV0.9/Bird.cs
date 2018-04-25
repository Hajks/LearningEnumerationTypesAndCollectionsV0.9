using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._9
{
    class Bird
    {
        public string Name { get; set; }
        public virtual void Fly()
        {
            Console.WriteLine("Frr... frrr ...");
        }
        public override string ToString()
        {
            {
                return "Ptak " + Name;
            }
        }
    }
}
