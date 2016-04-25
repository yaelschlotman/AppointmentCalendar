using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AppointmentCalendar.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext() : base("SQLConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public System.Data.Entity.DbSet<AppointmentCalendar.Models.Appointment> Appointments { get; set; }
    }
}
