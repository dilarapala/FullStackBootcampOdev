using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.SRP
{
    public class PhoneNumberValidator
    {
        public bool IsPhoneNumberValid(string input)
        {
            return true;
        }
    }

    public class SendSMS
    {
        private PhoneNumberValidator _validator = new PhoneNumberValidator();
        public bool SendSMSForX(string input, string phoneNumber)
        {
            if(!_validator.IsPhoneNumberValid(phoneNumber))
                return false;

            return true;
        }

    }
}
