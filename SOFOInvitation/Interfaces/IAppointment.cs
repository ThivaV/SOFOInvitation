using Microsoft.Office365.OutlookServices;
using SOFOInvitation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOFOInvitation.Interfaces
{
    public interface IAppointment<T> where T : class
    {
        Task<Appointment> CreateAppointment();

        Task<Event> GetEvent(string eventId);
    }
}
