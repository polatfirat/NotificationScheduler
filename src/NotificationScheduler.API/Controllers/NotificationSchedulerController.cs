using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotificationScheduler.Business;
using NotificationScheduler.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationScheduler.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationSchedulerController : ControllerBase
    {
        private readonly ILogger<NotificationSchedulerController> _logger;
        private readonly ISchedulerManager _schedulerManager;

        public NotificationSchedulerController(ILogger<NotificationSchedulerController> logger, ISchedulerManager schedulerManager)
        {
            _logger = logger;
            _schedulerManager = schedulerManager;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateScheduler([FromBody] Company company)
        {
            var result = await _schedulerManager.Notification(company);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return Ok(new { Result = "Only company created" });
            }

        }
    }
}
