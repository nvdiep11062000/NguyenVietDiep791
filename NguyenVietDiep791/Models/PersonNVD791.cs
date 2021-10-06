using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenVietDiep791.Models
{
    [Table("PersonNVD791s")]
    public class PersonNVD791
    {
        [Key]
        public string PersonId { get; set; }
        [Required]
        [StringLength(50)]

        public string PersonName { get; set; }
    }
}
