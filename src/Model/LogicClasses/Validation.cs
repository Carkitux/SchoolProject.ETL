using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace SchoolProject.ETL.Model.LogicClasses
{
    public class Validation
    {
        public static bool ValidateEMail(string eMail)
        {
            if (string.IsNullOrEmpty(eMail))
            { 
                return true; 
            }

            return Regex.IsMatch(eMail, @"^[^@.]+(.[^@.]+)?@[^@]+.[^@.]+$");
        }

        public static bool ValidateInteger(string integer)
        {
            if (string.IsNullOrEmpty(integer))
            {
                return true;
            }

            return int.TryParse(integer, out int value);
        }

        public static bool ValidatePostleitzahl(string postleitzahl)
        {
            if (string.IsNullOrEmpty(postleitzahl))
            {
                return true;
            }

            return postleitzahl.Length == 5;
        }

        public static bool ValidateBoolean(string boolean)
        {
            if (string.IsNullOrEmpty(boolean))
            {
                return true;
            }

            var lowercase = boolean.ToLower();

            if (bool.TryParse(boolean, out bool result))
                return result;
            else if (lowercase == "yes" || lowercase == "y" || lowercase == "j" || boolean == "1")
                return true;
            else if (lowercase == "no" || lowercase == "n" || boolean == "0")
                return false;
            else return false;
        }

        public static bool ValidateDate(string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                return true;
            }

            if (Regex.IsMatch(date, @"^\d{4}-\d{2}-\d{2}$"))
                return DateTime.TryParseExact(date, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            if (Regex.IsMatch(date, @"^\d{2}.\d{2}.\d{4}$"))
                return DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            return false;
        }
    }
}
