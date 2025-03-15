using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission_10_Smith.Data;

namespace Mission_10_Smith.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class BowlingController : ControllerBase
    {
        private BowlingLeagueContext _bowlingcontext;

        public BowlingController(BowlingLeagueContext temp)
        {
            _bowlingcontext = temp;
        }

        [HttpGet(Name = "BowlerInfo")]
        public IEnumerable<Bowler> Get()
        {
            var bowlers = _bowlingcontext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                .ToList();
            return (bowlers);
        }
    }
}