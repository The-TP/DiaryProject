using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.DanhMuc
{
    public class chi_nhanh
    {
        [Key]
        public int id { get; set; }
        [MaxLength(500)]
        [Required]
        public string ten_chi_nhanh { get; set; }
        public string ghi_chu { get; set; }
        public string ghi_chu1 { get; set; }
    }
}
