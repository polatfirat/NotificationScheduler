using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace NotificationScheduler.Domain.Entity.DataAnnotations
{
    class CompanyNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.ToString().Length > 10)
            {
                return new ValidationResult($"CustomerNumber cannot be more than 10 characters");
            }
            var regex = new Regex(@"[0-9+#-]");
            var result = regex.IsMatch(value.ToString());

            if (result)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"CustomerNumber value is not correct format");
            }

            
        }
    }
}
