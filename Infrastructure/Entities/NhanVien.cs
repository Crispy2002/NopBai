using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{  
        [Table("QLNV")]
        public class NhanVien 
        {
            [Key]
            public int MaNV { get; set; }
            public string HoTen { get; set; }
            public string DiaChi { get; set; }
            public int SDT { get; set; }

        }
    }
