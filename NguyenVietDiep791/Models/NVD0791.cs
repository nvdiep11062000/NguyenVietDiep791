using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenVietDiep791.Models
{
    public class NVD0791
    {
        [Key]
        public string NVDId { get; set; }
        public string NVDName { get; set; }
        [Required]
        [StringLength(50)]
        public string NVDGender { get; set; }
    }
}
