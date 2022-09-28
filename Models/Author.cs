using System;
using System.ComponentModel.DataAnnotations;

namespace NhanVienAPI.Models
{
    public class Author
    {
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}

