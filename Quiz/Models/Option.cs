using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.Models
{
    public class Option
    {
        [Key, Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Key, Column(Order = 0), ForeignKey("Question")]
        public int QuestionId { get; set; }

        [JsonIgnore]
        public virtual Question Question { get; set; }

        [JsonIgnore]
        public bool IsCorrect { get; set; }
    }
}