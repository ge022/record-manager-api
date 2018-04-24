using System;
using System.ComponentModel.DataAnnotations;

namespace Tutorial.Models
{
    public partial class Record
    {
        [Key, Required]
        public int RecordId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Rating { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

    }
    
}
