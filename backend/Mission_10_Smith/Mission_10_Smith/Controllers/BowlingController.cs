using Microsoft.AspNetCore.Mvc;
using Mission_10_Smith.Data;

namespace Mission_10_Smith.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class BowlingController : ControllerBase
    {
        private BowlingLeagueContext _bowlingContext;

        public BowlingController(BowlingLeagueContext temp)
        {
            _bowlingContext = temp;
        }

        [HttpGet(Name = "bowler")]
        public IEnumerable<Bowler> Get()
        {
            var bowlerList = _bowlingContext.Bowlers.ToList();
            return (bowlerList);
        }
    }
}