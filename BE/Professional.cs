using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    enum Degree { only_certificate, bachelors_degree, masters_degree, doctoral, student }
    public class Professional
    {
         public string IndetificationNumber { get; set; }
        string LastName_of_Professional { get; set; }
        string Name_of_Professional { get; set; }
        string date_of_Birth { get; set; }

        //  string CompanyName { get; set; } = null;
        string TelephoneNumber_of_the_Professional { get; set; }
        string Adress_of_the_Professional { get; set; }

        Degree degree { get; set; }

        bool Graduate_of_the_Army { get; set; }
        Bank bank;
        public override string ToString()
        {
            return "IndetificationNumber: " + IndetificationNumber + "\n" + "\n" + "LastName_of_Employee: " + LastName_of_Professional + "\n" + "Name_of_Employee: " + Name_of_Professional + "\n" + "date_of_Birth: " + date_of_Birth + "\n" + "TelephoneNumber_of_the_Employee: " + TelephoneNumber_of_the_Professional + "\n" + "Adress_of_the_Employee: " + Adress_of_the_Professional + "\n" + "Graduate_of_the_Army: " + Graduate_of_the_Army + "\n";
        }
    }

}




