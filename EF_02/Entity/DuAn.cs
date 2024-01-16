using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Entity
{
    public class DuAn
    {
        public int DuAnId { get; set; }
        [Required]
        [MaxLength(10)]
        public string TenDuAn { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
    }
}
