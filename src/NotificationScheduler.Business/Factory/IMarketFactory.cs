using NotificationScheduler.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotificationScheduler.Business.Market.Factory
{
    public interface IMarketFactory
    {
        Task<ScheduleResponse> CreateNotification(Company company);
    }
}
