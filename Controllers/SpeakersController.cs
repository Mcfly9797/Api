using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.DTOs;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakersController : ControllerBase
    {
        //Context
        private readonly MyDbContext _context;
        //Constructor
        public SpeakersController(MyDbContext context)
        {
            context = _context;
        }

        //Controladores
        [HttpGet]
        public async Task<IActionResult> GetSpeakers()
        {
            var speakersFromDatabase = await _context.Speakers.ToListAsync();
            var speakersDTO = new List<SpeakersDTO>();
            foreach (var speaker in speakersFromDatabase)
            {
                speakersDTO.Add(new SpeakersDTO
                {
                    SpeakerId = speaker.SpeakerId,
                    SpeakerName = speaker.SpeakerName,
                    Email = speaker.Email,
                    Country = speaker.Country,
                    Phone = speaker.Phone,
                    Duration = speaker.Duration
                });
            }
            return Ok(speakersDTO);
        }


        [HttpGet("Id")]
        public async Task<IActionResult> GetSpeakerById(int Id)
        {
            ObjectResult result;

            var speakerFromDatabase = await _context.Speakers.FindAsync(Id);

            if(speakerFromDatabase != null)
            {

                
                result = Ok(new SpeakersDTO{
                            SpeakerId = speakerFromDatabase.SpeakerId,
                            SpeakerName = speakerFromDatabase.SpeakerName,
                            Email = speakerFromDatabase.Email,
                            Country = speakerFromDatabase.Country,
                            Phone = speakerFromDatabase.Phone,
                            Duration = speakerFromDatabase.Duration
                    });
            }
            else
            {
                result = NotFound("No se encontraron datos");
            }
            return result;
        }
    }
}
