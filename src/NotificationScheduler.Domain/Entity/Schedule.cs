using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NotificationScheduler.Domain.Entity
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime Notifications { get; set; }
    }
}
