using FYP.Application.TodoItems.Commands.DeleteTodoItem;
using FYP.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Bookings;

namespace FYP.WebUI.Controllers;

[Authorize]
public class BookingController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Booking>>> GetBookings([FromQuery]GetBookings command)
    {
        return await Mediator.Send(command);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteBooking(id));

        return NoContent();
    }
}