using SchoolProject.ETL.Model.DataClasses;
using SchoolProject.ETL.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SchoolProject.ETL.Model.LogicClasses
{
    public class Validation
    {
        public static List<DataRowCell> Validate()
        {
            var stagingObject = StagingArea.TransformStObject;
            var failedCells = new List<DataRowCell>();

            foreach (var attribut in stagingObject.Attributes)
            {
                var cells = attribut.GetAssociatedDataRowCells();

                foreach (var cell in cells)
                {
                    if (ValidateSingle(cell, cell.Value))
                    {
                        cell.ValidationStatus = ValidationStatus.Valid;
                    }
                    else
                    {
                        failedCells.Add(cell);
                    }
                }
            }
            return failedCells;
        }
        public static bool ValidateSingle(DataRowCell cell, string newValue)
        {
            switch (cell.Attribut.Datatyp)
            {
                case Datatyp.ganzzahl:
                    return ValidateInteger(cell, newValue);
                case Datatyp.kommazahl:
                    return ValidateDecimal(cell, newValue);
                case Datatyp.text:
                    return ValidateTextLength(cell, cell.Value, cell.Attribut.MaxLength);
                case Datatyp.boolean:
                    return ValidateBoolean(cell, newValue);
                case Datatyp.email:
                    return ValidateEMail(cell, newValue);
                case Datatyp.datum:
                    return ValidateDate(cell, newValue);
                case Datatyp.plz:
                    return ValidatePostleitzahl(cell, newValue);
                default:
                    return false;
            }
        }

        private static bool ValidateInteger(DataRowCell cell, string value)
        {
            if (Skip(cell, value))
            {
                return true;
            }

            return int.TryParse(value, out int result);
        }
        private static bool ValidateDecimal(DataRowCell cell, string value)
        {
            if (Skip(cell, value))
            {
                return true;
            }

            return decimal.TryParse(value, out decimal result);
        }
        private static bool ValidateTextLength(DataRowCell cell, string value, int maxlength)
        {
            if (Skip(cell, value))
            {
                return true;
            }
            if (cell.Attribut.MaxLength > 0 && value.Length > cell.Attribut.MaxLength)
            {
                return false;
            }

            return true;
        }
        private static bool ValidateBoolean(DataRowCell cell, string value)
        {
            if (Skip(cell, value))
            {
                return true;
            }

            return bool.TryParse(value, out bool result);
        }
        private static bool ValidateEMail(DataRowCell cell, string value)
        {
            if (Skip(cell, value))
            {
                return true;
            }
            else if (Regex.IsMatch(value, @"^[^@.]+(.[^@.]+)?@[^@]+.[^@.]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool ValidateDate(DataRowCell cell, string value)
        {
            if (Skip(cell, value))
            {
                return true;
            }

            if (Regex.IsMatch(value, @"^\d{4}-\d{2}-\d{2}$"))
                return DateTime.TryParseExact(value, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            if (Regex.IsMatch(value, @"^\d{2}.\d{2}.\d{4}$"))
                return DateTime.TryParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            return false;
        }
        private static bool ValidatePostleitzahl(DataRowCell cell, string value)
        {
            if (Skip(cell, value))
            {
                return true;
            }

            return value.Length == 5 && int.TryParse(value, out int result);
        }

        private static bool Skip(DataRowCell cell, string value)
        {
            if (cell.ValidationStatus != Enums.ValidationStatus.Default || string.IsNullOrEmpty(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}