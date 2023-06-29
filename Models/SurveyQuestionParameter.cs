using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.DAL.Models
{
    public class SurveyQuestionParameter
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int ParameterTypeId { get; set; }
        public SurveyQuestionParameterType ParameterType { get; set; }
    }
}
