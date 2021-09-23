using NotificationScheduler.Business.Market.Factory;
using NotificationScheduler.Domain.Entity;
using NotificationScheduler.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationScheduler.Business
{
    public class SchedulerManager : ISchedulerManager
    {
        private readonly NotificationSchedulerContext _context;
        public SchedulerManager(NotificationSchedulerContext context)
        {
            _context = context;
        }
        public async Task<ScheduleResponse> Notification(Company company)
        {
            var marketFactory = MarketFactory.GetMarketFactory(_context, company.Market);
            return await marketFactory.CreateNotification(company);
        }
    }
}
