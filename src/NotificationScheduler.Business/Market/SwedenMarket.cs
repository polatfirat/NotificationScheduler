using NotificationScheduler.Business.Market.Factory;
using NotificationScheduler.Domain.Entity;
using NotificationScheduler.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationScheduler.Business.Market
{
    public class SwedenMarket : BaseMarket, IMarketFactory
    {
        public SwedenMarket(NotificationSchedulerContext context) : base(context)
        {

        }
        public async Task<ScheduleResponse> CreateNotification(Company company)
        {
            var dayList = new List<int>() { 1, 7, 14, 28 };
            var companyId = await base.InsertCompany(company);

            if (company.CompanyType == Domain.Enum.CompanyType.Small && company.CompanyType == Domain.Enum.CompanyType.Medium)
            {
                var scheduleList = await base.CreateNotificationDate(dayList, company);
                return scheduleList;
            }
            else
            {
                return null;
            }
        }
    }
}
