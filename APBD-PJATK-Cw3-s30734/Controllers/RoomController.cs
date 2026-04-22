using Microsoft.AspNetCore.Mvc;

namespace APBD_PJATK_Cw3_s30734.Controllers;

[ApiController]
[Route("[controller]")]
public class RoomController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllRooms()
    {
        return Ok();
    }
}