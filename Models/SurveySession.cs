using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.DAL.Models
{
    public class SurveySession
    {
        public Guid Id { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
        public string PersonFullName { get; set; }
        public string PersonPhoneNumber { get; set; }
        public string PersonEmail { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime CompletedAt { get; set; }
    }
}
