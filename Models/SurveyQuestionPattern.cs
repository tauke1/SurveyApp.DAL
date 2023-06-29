using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.DAL.Models
{
    public class SurveyQuestionPattern
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SurveyQuestionInputType InputTypeId { get; set; }
        public List<SurveyQuestionPatternRequiredParameter> RequiredParameters { get; set; }
    }
}
