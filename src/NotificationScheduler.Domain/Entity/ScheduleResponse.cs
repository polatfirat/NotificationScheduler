using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NotificationScheduler.Domain.Entity
{
    public class ScheduleResponse
    {
        public Guid CompanyId { get; set; }
        public List<string> Notifications { get; set; }
    }
}
