using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    enum Sector { database, communications, security, mobile_programming, user_interface_desing };
    public class Specialization
    {
        static int NumberExpertise = 9999999;
        Sector sector { get; set; }
        string NameExpertise { get; set; }
        /// <summary>
        /// The maximum hourly wage and minimum salary of the market
        /// </summary>
        double MinimumRate { get; set; }
        double MaximumRate { get; set; }

        public override string ToString()
        {
            return "NumberExpertise: " + NumberExpertise + "\n" + "sector: " + sector + "\n" + "NameExpertise: " + NameExpertise + "\n" + "MinimumRate: " + MinimumRate + "\n" + "MaximumRate: " + MaximumRate + "\n";
        }




        /// <summary>
        /// Print the Detail of this class
        /// </summary>
        /// <returns></returns>


        //ctor
        Specialization()
        {

            NumberExpertise++;

        }
    }
}
