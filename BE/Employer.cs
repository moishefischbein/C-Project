using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employer
    {
        string IndetificationNumber { get; set; }
        bool Company_or_Individual { get; set; }
        string LastName_of_Employer { get; set; }
        string Name_of_Employer { get; set; }

        string CompanyName { get; set; } = null;
        string TelephoneNumber_of_the_Employer { get; set; }
        string Adress_of_the_Employer { get; set; }

        string Date_of_Establishment { get; set; }
        public override string ToString()
        {
            return "IndetificationNumber: " + IndetificationNumber + "\n" + "Company_or_Individual: " + Company_or_Individual + "\n" + "LastName_of_Employer: " + LastName_of_Employer + "\n" + "Name_of_Employer: " + Name_of_Employer + "\n" + "CompanyName: " + CompanyName + "\n" + "TelephoneNumber_of_the_Employer: " + TelephoneNumber_of_the_Employer + "\n" + "Adress_of_the_Employer: " + Adress_of_the_Employer + "\n" + "Date_of_Establishment: " + Date_of_Establishment + "\n";
        }

    }

      
            
    }




