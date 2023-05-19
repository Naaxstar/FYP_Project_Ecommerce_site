using FYP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Bookings;

namespace FYP.WebUI.Controllers;

public class BookingController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Booking>>> Create([FromQuery]GetBookings command)
    {
        return await Mediator.Send(command);
    }
}