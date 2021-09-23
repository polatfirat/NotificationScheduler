using NotificationScheduler.Domain.Entity;
using NotificationScheduler.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationScheduler.Business.Market
{
    public class BaseMarket
    {
        private readonly NotificationSchedulerContext _context;
        public BaseMarket(NotificationSchedulerContext context)
        {
            _context = context;
        }

        public async Task<ScheduleResponse> CreateNotificationDate(List<int> dayList, Company company)
        {
            var scheduleList = GenerateNotificationList(dayList, company);
            
            return await InsertSchedule(scheduleList, company.Id);
        }

        public List<Schedule> GenerateNotificationList(List<int> dayList, Company company)
        {
            var scheduleList = new List<Schedule>();

            if (company.NotificationList == null)
            {
                for (int i = 0; i < dayList.Count; i++)
                {
                    var notificationDate = DateTime.Now;
                    scheduleList.Add(new Schedule { CompanyId = company.Id, Notifications = notificationDate.AddDays(dayList[i]) });
                }
            }
            else
            {
                foreach (var item in company.NotificationList)
                {
                    scheduleList.Add(new Schedule { CompanyId = company.Id, Notifications = item });
                }
            }

            return scheduleList;
        }
        public async Task<Guid> InsertCompany(Company company)
        {
            _context.Company.Add(company);
            await _context.SaveChangesAsync();

            return company.Id;
        }

        public async Task<ScheduleResponse> InsertSchedule(List<Schedule> scheduleList, Guid companyId)
        {
            await _context.Schedule.AddRangeAsync(scheduleList);
            await _context.SaveChangesAsync();

            var schedulerResponse = new ScheduleResponse();

            schedulerResponse.CompanyId = companyId;
            schedulerResponse.Notifications = scheduleList.Select(r => r.Notifications.ToString("dd'/'MM'/'yyyy")).ToList();


            return schedulerResponse;
        }
    }
}
