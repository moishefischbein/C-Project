using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Contracts
    {
        static long NumberContract = 9999999;

        string Number_Contract { get; set; }

        string IndetificationNumberEmployer { get; set; }
        string IndetificationNumberEmployee { get; set; }

        bool InterviewConducted { get; set; }

        bool SignedContract { get; set; }
        /// <summary>
        /// when the employee start to work
        /// </summary>
        string Commencement_of_Employment { get; set; }

        int Several_Hours_of_Employment { get; set; }

        public override string ToString()
        {
            return ("IndetificationNumberEmployer: " + IndetificationNumberEmployer + "\n" + "IndetificationNumberEmployee: " + IndetificationNumberEmployee + "\n" + "Number_Contract: " + Number_Contract + "\n" + "InterviewConducted: " + InterviewConducted + "\n" + "SignedContract: " + SignedContract + "\n" + "Commencement_of_Employment: " + Commencement_of_Employment + "\n" + "Several_Hours_of_Employment: " + Several_Hours_of_Employment + "\n");
        }


        //ctor
        Contracts()
        {
            NumberContract++;
            Number_Contract = Convert.ToString(NumberContract);
        }

    }
}
