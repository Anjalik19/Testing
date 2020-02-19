using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XUnitTesting
{
    class Regestration
    {
        public bool FirstName(string FName)
        {
            var FirstNameRegex = "^[a-zA-Z].{4,8}$";
            Regex reg = new Regex(FirstNameRegex);
            if (reg.IsMatch(FName))
            {
                return true;
            }
            else
            
                return false;

        }
    

        public bool LastName(string LName)
        {
            var LNameRegex = "^[a-zA-Z].{4,8}$";
            Regex reg = new Regex(LNameRegex);
            if (reg.IsMatch(LName))
            {
                return true;
            }
            return false;
        }
        public bool password(string pass)
        {
            var passRegex = "^[a-zA-Z0-9].{4,8}$";
            Regex reg = new Regex(passRegex);
            if(reg.IsMatch(pass))
            {
                return true;
            }
            return false;
        }
        public bool PhNum(string phNum)
        {
            var numRegex = "^[0-9]*$";
            Regex reg = new Regex(numRegex);
            if(reg.IsMatch(phNum))
            {
                return true;
            }
            return false;
        }

        public  bool Email(string inputEmail)
        {
            string emailRegex = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]{1,5}";
            Regex reg = new Regex(emailRegex);
            if (reg.IsMatch(inputEmail))
                return true;
            else
                return false;
        }
    }
}  
