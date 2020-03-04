using System;
using System.ComponentModel.DataAnnotations;

namespace AH.API.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        public string Creator { get; set; }
        public string Title { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Body { get; set; }
        public DateTime Dt { get; set; }
    }
}