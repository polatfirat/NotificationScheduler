using NotificationScheduler.Business.Market.Factory;
using NotificationScheduler.Domain.Entity;
using NotificationScheduler.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationScheduler.Business.Market
{
    public class DenmarkMarket : BaseMarket, IMarketFactory
    {
        public DenmarkMarket(NotificationSchedulerContext context) : base(context)
        {

        }
        public async Task<ScheduleResponse> CreateNotification(Company company)
        {
            var dayList = new List<int>() { 1, 5, 10, 15, 20 };
            var companyId = await base.InsertCompany(company);
            var scheduleList = await base.CreateNotificationDate(dayList, company);

            return scheduleList;
        }
    }
}
