using System.Globalization;
using System.Windows.Controls;
using FitnessClub.Models;
using System;

namespace FitnessClub.Tools
{
    class IsDateFinValidationRule : ValidationRule
    {
        #region Properties
        public string ErrorMessage { get; set; }
        #endregion
        #region Overrides of ValidationRule
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var result = new ValidationResult(true, null);
            int memberId = int.Parse(value.ToString());

            var abonnement = new DataService().GetAbonnements(memberId);
            var t = abonnement.Length - 1;

            if (abonnement.Length == 0)
                result = new ValidationResult(false, ErrorMessage);
            else
                if (abonnement[t].FinAbonnement < DateTime.Now)
                    result = new ValidationResult(false, ErrorMessage);
            return result;
        }
        #endregion
    }
}
