using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.models
{
    public class users
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime entry { get; set; }

        public override string ToString()
        {
            return $"{ID},{Name},{PhoneNumber},{Birthday.ToString()},{entry.ToString()}";
        }


    }
    


}
