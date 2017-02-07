using Microsoft.AspNetCore.Mvc;

[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index ()
    {
        return Ok("This is the index of the Customer Care Page");
    }
        [Route("fileclaim")]
        public IActionResult NewClaim ()
    {
        return Ok("This is the page to file a new Claim");
    }
    [Route("myclaims")]

    public IActionResult ClaimHistory()
    {
        return Ok("This is the Claim History Page");
    }
}
