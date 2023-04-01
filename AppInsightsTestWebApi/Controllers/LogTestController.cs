using Microsoft.AspNetCore.Mvc;

namespace AppInsightsTestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogTestController : ControllerBase
    {
        private readonly ILogger<LogTestController> _logger;

        public LogTestController(ILogger<LogTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "LoggingTest")]
        public IEnumerable<string> Get()
        {
            _logger.LogTrace("Trace");
            _logger.LogDebug("Debug");
            _logger.LogInformation("Info");
            _logger.LogWarning("Warning");

            return Enumerable
                .Range(1, 5)
                .Select(x => x.ToString());
        }
    }
}