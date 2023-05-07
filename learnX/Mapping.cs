using AutoMapper;
using Infrastructure.Entities;
using learnX.Models;

namespace learnX
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<NhanVien, NhanVienViewModel>();
            CreateMap<NhanVienViewModel, NhanVien>();
        }
    }
}
