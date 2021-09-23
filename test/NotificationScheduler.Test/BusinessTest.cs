using NotificationScheduler.Business.Market;
using NotificationScheduler.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace NotificationScheduler.Test
{
    public class BusinessTest
    {
        public BusinessTest()
        {

        }
        [Fact]
        public void GenerateCorrectDate()
        {
            var company = new Company();
            company.CompanyName = "Test";
            company.CompanyNumber = "123-123";

            var baseMarket = new BaseMarket(null);
            var result = baseMarket.GenerateNotificationList(new List<int>() { 1, 5, 10, 15, 20 }, company);

            var thirdDay = DateTime.Now.AddDays(10);

            Assert.Equal(result[2].Notifications.Day, thirdDay.Day);


        }

        [Fact]
        public void GenerateInCorrectDate()
        {
            var company = new Company();
            company.CompanyName = "Test";
            company.CompanyNumber = "123-123";

            var baseMarket = new BaseMarket(null);
            var result = baseMarket.GenerateNotificationList(new List<int>() { 1, 4, 8, 15 }, company);

            var secondDay = DateTime.Now.AddDays(2);

            Assert.NotEqual(result[2].Notifications.Day, secondDay.Day);
        }
    }
}
