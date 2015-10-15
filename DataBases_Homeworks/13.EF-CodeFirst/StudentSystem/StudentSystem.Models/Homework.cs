namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public int HomeworkId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DeadLine { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

    }
}
