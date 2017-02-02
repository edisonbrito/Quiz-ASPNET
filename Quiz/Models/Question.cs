using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Quiz.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual List<Option> Options { get; set; }

    }
}