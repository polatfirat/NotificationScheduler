using NotificationScheduler.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace NotificationScheduler.Test
{
    public class ValidationTest
    {
        [Fact]
        public void CompanyNumberValidValue()
        {
            var company = new Company();
            company.CompanyName = "Test";
            company.CompanyNumber = "123-123";

            var context = new ValidationContext(company, null, null);
            var validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(company, context, validationResults, true);
            Assert.Equal(true, valid);
        }

        [Fact]
        public void CompanyNumberInvalidValue()
        {
            var company = new Company();
            company.CompanyName = "Test";
            company.CompanyNumber = "Test";

            var context = new ValidationContext(company, null, null);
            var validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(company, context, validationResults, true);
            Assert.NotEqual(true, valid);
        }
    }
}
