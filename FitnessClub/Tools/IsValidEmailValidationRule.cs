using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace FitnessClub.Tools
{
    public class IsValidEmailValidationRule : ValidationRule
    {

        #region Properties
        public string ErrorMessage { get; set; }
        #endregion
        #region Overrides of ValidationRule
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var result = new ValidationResult(true, null);
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +

                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +

                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regex = new Regex(strRegex);
            if (!regex.Match(Convert.ToString(value)).Success)
            {
                result = new ValidationResult(false, this.ErrorMessage);
            }
            return result;
        }
        #endregion
    }
}
