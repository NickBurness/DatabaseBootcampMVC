using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseBootcampMVC.Models
{
    public class Attendees
    {

        public int AttendeeID { get; set; }
        public int EventID { get; set; }
        public int UserID { get; set; }
        public bool isAttending { get; set; }
        public int Guests { get; set; }
    }
}
