using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoomService.Models;
using RoomService.Repository;

namespace RoomService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Room> rooms = RoomRepository.GetRooms();


            return Ok(rooms);
        }
    }
}
