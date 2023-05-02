using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace SchoolProject.ETL.Model.LogicClasses.Validation
{
    public class Validation
    {
        public static bool ValidateEMail(string eMail)
        {
            return Regex.IsMatch(eMail, @"^[^@.]+(.[^@.]+)?@[^@]+.[^@.]+$");
        }

        public static bool ValidateInteger(string integer)
        {
            return int.TryParse(integer, out int value);
        }

        public static bool ValidatePostleitzahl(string postleitzahl)
        {
            return postleitzahl.Length == 5;
        }

        public static bool ValidateBoolean(string boolean)
        {
            var lowercase = boolean.ToLower();

            if (bool.TryParse(boolean, out bool result))
                return result;
            else if (lowercase == "yes" || lowercase == "y" || lowercase == "j" || boolean == "1")
                return true;
            else if (lowercase == "no" || lowercase == "n" || boolean == "0")
                return false;
            else return false;
        }

        public static bool ValidateDatum(string datum)
        {
            if (Regex.IsMatch(datum, @"^\d{4}-\d{2}-\d{2}$"))
                return DateTime.TryParseExact(datum, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            if (Regex.IsMatch(datum, @"^\d{2}.\d{2}.\d{4}$"))
                return DateTime.TryParseExact(datum, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            return false;
        }

        //public static bool ValidateGeschlecht(string geschlecht)
        //{

        //}
    }
}
