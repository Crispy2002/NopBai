using Infrastructure.Entities;
using Infrastructure.Repository;
using System.Linq;

namespace Infrastructure.Service
{
    public interface INhanVienService
    {
        IQueryable<NhanVien> GetNhanViens();
        NhanVien GetNhanVien(int MaNV);
        void InsertNhanVien(NhanVien nhanvien);
        void UpdateNhanVien(NhanVien nhanvien);
        void DeleteNhanVien(NhanVien nhanvien);
    }

    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository nhanvienRepository;

        public NhanVienService(INhanVienRepository nhanvienRepository)
        {
            this.nhanvienRepository = nhanvienRepository;
        }

        public IQueryable<NhanVien> GetNhanViens()
        {
            return nhanvienRepository.GetAll();
        }

        public NhanVien GetNhanVien(int MaNV)
        {
            return nhanvienRepository.GetById(MaNV);
        }

        public void InsertNhanVien(NhanVien nhanvien)
        {
            nhanvienRepository.Insert(nhanvien);
        }

        public void UpdateNhanVien(NhanVien nhanvien)
        {
            nhanvienRepository.Update(nhanvien);
        }

        public void DeleteNhanVien(NhanVien nhanvien)
        {
            nhanvienRepository.Delete(nhanvien);
        }
    }
}
