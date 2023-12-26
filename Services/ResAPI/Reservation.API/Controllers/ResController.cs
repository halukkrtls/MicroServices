using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Services;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService ReservationService)
        {
            reservationService = ReservationService;
        }

        [HttpGet("{Id}")]
        public Models.ReservationDTO Get(int Id)
        {
            return reservationService.GetResByBkgNumber(Id);
        }
    }
}
