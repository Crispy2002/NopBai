using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace learnX.Models
{
    public class NhanVienViewModel
    {
        public NhanVienViewModel()
        {
        }

        [DisplayName("MaNV")]
        public int MaNV { get; set; }

        [DisplayName("Họ và tên")]
        [MaxLength(30, ErrorMessage = "Họ và tên không quá 30 ký tự.")]
        public string HoTen { get; set; }

        [DisplayName("Dia Chi")]
        [MaxLength(100, ErrorMessage = "Họ và tên không quá 100 ký tự.")]
        public string DiaChi { get; set; }

        [DisplayName("Điện thoại")]
        public int SDT { get; set; }

    }
}
