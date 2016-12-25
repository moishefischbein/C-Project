using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace DAL
{
    interface Interface_Idal
    {
        void AddSpecialization(Specialization s);
        void DeleteSpecialization(Specialization s);
        void Updating_Existing_Specialization(Specialization s);

        //...................................//
        void AddProfessional(Professional p);
        void DeleteProfessional(Professional p);
        void Update_Existing_Professional(Professional p);

        //.....................................//
        void AddEmployer(Employer employer);
        void DeleteEmployer(Employer employer);
        void Update_Existing_Employer(Employer employer);

        //....................................//
        void AddContract(Contracts contract);
        void UpdateContract(Contracts contract);
        void DeleteContract(Contracts contract);

        //.....................................//
        List<Specialization> Receive_List_all_Specialization();
        List<Professional> Receive_List_all_Professionals();
        List<Employer> Receive_List_all_Employers();
        List<Contracts> Receive_List_all_Contracts();

        List<Bank> List_Bank_Branches();

    }
}
