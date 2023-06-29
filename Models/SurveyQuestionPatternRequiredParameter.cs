using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.DAL.Models
{
    public class SurveyQuestionPatternRequiredParameter
    {
        public int Id { get; set; }
        public int PatternId { get; set; }
        public SurveyQuestionPattern Pattern { get; set; }
        public int ParameterId { get; set; }
        public SurveyQuestionParameter Parameter { get; set; }
    }
}
