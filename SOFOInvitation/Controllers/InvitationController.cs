using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Office365.OutlookServices;
using Newtonsoft.Json;
using SOFOInvitation.Interfaces;
using SOFOInvitation.Models;

namespace SOFOInvitation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationController : ControllerBase
    {
        private readonly IAppointment<Event> _appointment;

        public InvitationController(IAppointment<Event> appointment) 
        {
            _appointment = appointment;
        }

        // POST: api/Invitation
        [HttpPost]
        public IActionResult Post(string validationtoken)
        {
            if (validationtoken != null)
            {
                return Ok(validationtoken);
            }

            return BadRequest();
        }

        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Post([FromBody] Object notification)
        {
            Notification calendarEvent = JsonConvert.DeserializeObject<Notification>(notification.ToString());
            Event iCalEvent = await _appointment.GetEvent(calendarEvent.Value[0].ResourceData.Id);

            return Ok();
        }
        
        [HttpPost("invitationtester/{eventid}")]
        public async Task<IActionResult> invitationtester(string eventid)
        {
            Event iCalEvent = await _appointment.GetEvent(eventid);
                        
            return Ok();
        }
    }

    /*public MemoryStream GetICal()
    {
        var attendees = calendarModel.Attendees.Select(x => new Ical.Net.DataTypes.Attendee()
        {
            CommonName = x.AttendeeName,
            ParticipationStatus = "REQ-PARTICIPANT",
            Rsvp = true,
            Value = new Uri($"mailto:{x.AttendeeEmail}")
        }).ToList();

        

        var e = new CalendarEvent
        {
            Summary = calendarModel.Name,
            IsAllDay = true,
            Organizer = new Ical.Net.DataTypes.Organizer()
            {
                CommonName = "",
                Value = new Uri("")
            },
            Attendees = attendees,
            Start = new CalDateTime(calendarModel.StartDateTime.Date),
            Transparency = TransparencyType.Transparent,
            Location = calendarModel.Location,
            Description = calendarModel.Description
        };

        var calendar = new Calendar();
        calendar.Events.Add(e);

        var serializer = new CalendarSerializer(new SerializationContext());
        var serializedCalendar = serializer.SerializeToString(calendar);
        var bytesCalendar = Encoding.UTF8.GetBytes(serializedCalendar);
        MemoryStream ms = new MemoryStream(bytesCalendar);

        return ms;
    }*/
}