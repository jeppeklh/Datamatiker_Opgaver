using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Uge13Opgaver
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public bool IsMarried { get; set; }
        public int NoOfChildren { get; set; }

        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            if(name.Length < 1)
            {
                throw new Exception("Der er opstået en fejl … eller hvad der nu er relevant at skrive her");
            }

            if(height <= 0)
            {
                throw new Exception("Der er opstået en fejl … eller hvad der nu er relevant at skrive her");
            }

            if(birthDate < new DateTime(1900, 1, 1))
            {
                throw new Exception("Der er opstået en fejl … eller hvad der nu er relevant at skrive her");
            }

            if(noOfChildren < 0)
            {
                throw new Exception("Der er opstået en fejl … eller hvad der nu er relevant at skrive her");
            }

            this.Name = name;
            this.BirthDate = birthDate;
            this.Height = height;
            this.IsMarried = isMarried;
            this.NoOfChildren = noOfChildren;
        }

        //Overloaded constructor - kalder første constructor. (Underlig notation)
        public Person(string name, DateTime birthdate, double height, bool isMarried) : this(name, birthdate, height, isMarried, 0)
        {

        }

        public string MakeTitle()
        {
            CultureInfo culture = new CultureInfo("en-US");
            return $"{Name};{BirthDate.ToString("dd-MM-yyyy HH:mm:ss", culture)};{Height};{IsMarried};{NoOfChildren}";
        }
    }
}
