using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;

namespace Infrastructure.Repository
{
    public interface INhanVienRepository : IRepository<NhanVien>
    {
    }

    public class NhanVienRepository : Repository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(EXDbContext context) : base(context)
        {
        }
    }
}
