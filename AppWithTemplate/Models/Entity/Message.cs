using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWithTemplate.Models.Entity
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string GivenName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Content { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }


        public DateTime? AnswerDate { get; set; }
        public string AnswerContent { get; set; }
    }
}
