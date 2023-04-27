using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.ETL.ModelLogic.Validation
{
    public class Validation
    {
        public static bool ValidateEMail(string eMail)
        {
            return eMail.Contains('@') && eMail.Contains('.');
        }
    }
}
