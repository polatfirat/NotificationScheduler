using NotificationScheduler.Domain.Entity.DataAnnotations;
using NotificationScheduler.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NotificationScheduler.Domain.Entity
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public string CompanyName { get; set; }

        [CompanyNumber]
        public string CompanyNumber { get; set; }
        public CompanyType CompanyType { get; set; }
        public Market Market { get; set; }

        [NotMapped]
        public List<DateTime> NotificationList { get; set; }

    }
}
