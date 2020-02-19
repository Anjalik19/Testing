using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XUnitTesting
{
    class Regestration
    {
        //Regex Condition for first name when value is not null
        public bool FirstName(string FName)
        {
            var FirstNameRegex = "^[a-zA-Z].{4,8}$";
            Regex reg = new Regex(FirstNameRegex);
            if (FName != null)
            {
                if (reg.IsMatch(FName))
                {

                    return true;
                }
            }
            return false;
        }

        //Regex Condition for first name when value is null
        public bool fname(string name1)
        {
            var FirstNameRegex = "^[a-zA-Z].{4,8}$";
            Regex reg = new Regex(FirstNameRegex);
            if (name1==null)
            {
                if (reg.IsMatch(name1))
                {
                    return true;
                }
            }
            return true;
        }

        //Regex Condition for last name when value is not null
        public bool LastName(string LName)
        {
            var LNameRegex = "^[a-zA-Z].{4,8}$";
            Regex reg = new Regex(LNameRegex);
            if (LName != null)
            {
                if (reg.IsMatch(LName))
                {
                    return true;
                }
            }
            return false;
        }

        //Regex Condition for first name when value is  null
        public bool lname(string name2)
        {
            var LNameRegex = "^[a-zA-Z].{4,8}$";
            Regex reg = new Regex(LNameRegex);
            if (name2 == null)
            {
                if (reg.IsMatch(name2))
                {
                    return true;
                }
            }
            return true;
        }

        //Regex Condition for password when value is not null
        public bool password(string pass)
        {
            var passRegex = "^[a-zA-Z0-9].{4,8}$";
            Regex reg = new Regex(passRegex);
            if (pass != null)
            {
                if (reg.IsMatch(pass))
                {
                    return true;
                }
            }
            return false;
        }

        //Regex Condition for password when value is  null
        public bool passwrd(string pass1)
        {
            var passRegex = "^[a-zA-Z0-9].{4,8}$";
            Regex reg = new Regex(passRegex);
            if (pass1 == null)
            {
                if (reg.IsMatch(pass1))
                {
                    return true;
                }
            }
            return true;
        }

        //Regex Condition for phone number when value is not null
        public bool PhNum(string phNum)
        {
            var numRegex = "^[0-9]*$";
            Regex reg = new Regex(numRegex);
            if (phNum != null)
            {
                if (reg.IsMatch(phNum))
                {
                    return true;
                }
            }
            return false;
        }

        //Regex Condition for phone number when value is null
        public bool mobile(string num)
        {
            var numRegex = "^[0-9]*$";
            Regex reg = new Regex(numRegex);
            if (num == null)
            {
                if (reg.IsMatch(num))
                {
                    return true;
                }
            }
            return true;
        }

        //Regex Condition for Email when value is not null
        public bool Email(string inputEmail)
        {
            string emailRegex = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]{1,5}";
            Regex reg = new Regex(emailRegex);
            if (inputEmail != null)
            {
                if (reg.IsMatch(inputEmail))
                {
                    return true;
                }
            }
                return false;
        }

        //Regex Condition for Email when value is null
        public bool mail(string email)
        {
            string emailRegex = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]{1,5}";
            Regex reg = new Regex(emailRegex);
            if (email == null)
            {
                if (reg.IsMatch(email))
                {
                    return true;
                }
            }
            return true;
        }
    }
}  
