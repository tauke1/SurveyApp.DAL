using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.DAL.Models
{
    public class SurveySessionAnswer
    {
        public int Id { get; set; }
        public Guid SessionId { get; set; }
        public SurveySession Session { get; set; }
        public int QuestionId { get; set; }
        public SurveyQuestion Question { get; set; }
        public string Value { get; set; }
        public string Explanation { get; set; }
    }
}
