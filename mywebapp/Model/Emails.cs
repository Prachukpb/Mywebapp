using System;
using System.ComponentModel.DataAnnotations;

namespace mywebapp.Model
{
    public class Emails
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Emailaddr { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public DateTime messagedOn { get; set; }
    }
}