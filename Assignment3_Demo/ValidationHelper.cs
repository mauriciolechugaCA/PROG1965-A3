using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3
{
    public class ValidationHelper
    {
        public StringBuilder alertMessages;

        public ValidationHelper(StringBuilder alertMessages)
        {
            this.alertMessages = alertMessages;
        }

        public bool IsValidPatientName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                alertMessages.AppendLine("Patient Name is required.");
                return false;
            }
            return true;
        }

        
        public bool IsValidPatientDOB(DateTime dob)
        {
            if (dob > DateTime.Now)
            {
                alertMessages.AppendLine("Date of Birth cannot be in the future.");
                return false;
            }
            return true;
        }
    }
}
