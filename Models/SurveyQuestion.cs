using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.DAL.Models
{
    public class SurveyQuestion
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
        public SurveyQuestionPattern Pattern { get; set; }
        public int PatternId { get; set; }
        public bool Required { get; set; }
        public bool AskForExplanation { get; set; }
        public string CustomExplanationQuestionText { get; set; }
        public int Order { get; set; }
        public List<SurveyQuestionParameter> Parameters { get; set; }
    }
}
