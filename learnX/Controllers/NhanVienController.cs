using AutoMapper;
using Infrastructure.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using learnX.Models;

namespace learnX.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly INhanVienService nhanvienService;
        private readonly IMapper mapper;
        public NhanVienController(INhanVienService nhanvienService, IMapper mapper)
        {
            this.nhanvienService = nhanvienService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(nhanvienService.GetNhanViens());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            NhanVienViewModel data = new NhanVienViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI NHÂN VIÊN " : "CẬP NHẬT THÔNG TIN";

            if (id != 0)
            {
                NhanVien res = nhanvienService.GetNhanVien(id);
                data = mapper.Map<NhanVienViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, NhanVienViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI NHÂN VIÊN " : "CẬP NHẬT THÔNG TIN";

            if (ModelState.IsValid)
            {
                try
                {
                    NhanVien res = mapper.Map<NhanVien>(data);
                    if (id != 0)
                    {
                        nhanvienService.UpdateNhanVien(res);
                    }
                
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "NhanVien");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int MaNV)
        {
            NhanVien res = nhanvienService.GetNhanVien(MaNV);
            nhanvienService.DeleteNhanVien(res);

            return RedirectToAction("Index", "NhanVien");
        }
    }
}

