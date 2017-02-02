using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("Option"), Column(Order = 1)]
        public int OptionId { get; set; }

        [ForeignKey("Option"), Column(Order = 0)]
        public int QuestionId { get; set; }

        public bool isCorrect { get; set; }

        public DateTime ExpireDate { get; set; }

        [JsonIgnore]
        public virtual Option Option { get; set; }
    }
}