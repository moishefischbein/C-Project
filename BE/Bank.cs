using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bank
    {

        string _BankNumber;
        string _banksName;
        int _branchNumber;
        string _branchAddress;
        string _CityBranch;
        string _Number;

        public string BankNumber
        {
            get
            {
                return _BankNumber;
            }

            set
            {
                if (value.Length < 10)
                    throw new Exception("Bank number must have 10 characters");

                _BankNumber = value;
            }
        }

        public string BanksName
        {
            get
            {
                return _banksName;
            }

            set
            {
                _banksName = value;
            }
        }

        public int BranchNumber
        {
            get
            {
                return _branchNumber;
            }

            set
            {
                _branchNumber = value;
            }
        }

        public string BranchAddress
        {
            get
            {
                return _branchAddress;
            }

            set
            {
                _branchAddress = value;
            }
        }

        public string CityBranch
        {
            get
            {
                return _CityBranch;
            }

            set
            {
                _CityBranch = value;
            }
        }

        public string Number
        {
            get
            {
                return _Number;
            }

            set
            {
                _Number = value;
            }
        }

        //ctor
        public Bank()
        {

        }

        public Bank(string name)
        {
            BanksName = name;
        }

        public Bank(string _BankNumber, string _banksName, int _branchNumber, string _branchAddress, string _CityBranch, string _Number)
        {
            this._BankNumber = _BankNumber;
            this._banksName = _banksName;
            this._branchNumber = _branchNumber;
            this._branchAddress = _branchAddress;
            this._CityBranch = _CityBranch;
            this._Number = _Number;
        }
    }
}
