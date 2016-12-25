using BE;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS;

namespace DAL
{
    class Dal_imp : Interface_Idal
    {
        public void AddContract(Contracts contract)
        {
            DataSource.list_Contarcts.Add(contract);

        }

        public void AddEmployer(Employer employer)
        {
            DataSource.list_Employer.Add(employer);
        }

        public void AddSpecialization(Specialization specialization)
        {
            DataSource.list_Specialization.Add(specialization);
        }

        public void AddProfessional(Professional professional)
        {
            DataSource.list_Professional.Add(professional);
        }

        public void DeleteContract(Contracts contract)
        {

            DataSource.list_Contarcts.Remove(contract);
        }

        public void DeleteEmployer(Employer employer)
        {
            DataSource.list_Employer.Remove(employer);
        }

        public void DeleteSpecialization(Specialization specialization)
        {
            DataSource.list_Specialization.Remove(specialization);
        }

        public void DeleteProfessional(Professional professional)
        {
            DataSource.list_Professional.Remove(professional);
        }

        public List<Bank> List_Bank_Branches()
        {
            
            List<Bank> bank = new List<Bank>();
            bank.Add(new Bank("Discont"));
            bank.Add(new Bank("Leumi"));
            bank.Add(new Bank("Hapoalim"));
            bank.Add(new Bank("Doar"));
            bank.Add(new Bank("Binleumi"));
            return bank;

        }

        public List<Contracts> Receive_List_all_Contracts()
        {
            return DataSource.list_Contarcts;
        }

        public List<Employer> Receive_List_all_Employers()
        {
            return DataSource.list_Employer;
        }

        public List<Professional> Receive_List_all_Professional()
        {
            return DataSource.list_Professional;
        }

        public List<Specialization> Receive_List_all_Specialization()
        {
            return DataSource.list_Specialization;
        }

        public void UpdateContract(Contracts contract)
        {
            throw new NotImplementedException();
        }

        public void Update_Existing_Employer(Employer employer)
        {
            throw new NotImplementedException();
        }

        public void Update_Existing_Professional()
        {
            throw new NotImplementedException();
        }

        public void Updating_Existing_Specialization()
        {
            throw new NotImplementedException();
        }

        public void Updating_Existing_Specialization(Specialization s)
        {
            throw new NotImplementedException();
        }

        public void Update_Existing_Professional(Professional p)
        {
            throw new NotImplementedException();
        }

        public List<Professional> Receive_List_all_Professionals()
        {
            throw new NotImplementedException();
        }
    }
}
