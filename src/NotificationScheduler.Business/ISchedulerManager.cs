using NotificationScheduler.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationScheduler.Business
{
    public interface ISchedulerManager
    {
        Task<ScheduleResponse> Notification(Company company);
    }
}
