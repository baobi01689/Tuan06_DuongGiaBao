using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tuan06_DuongGiaBao.Models;

namespace Tuan06_DuongGiaBao.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach { Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName = "Nguyễn Nhật Ánh", Price = 1, Content="Truyện kể về tuổi thơ ..."},
            new Sach { Id = 2, Title = "Pro ASP.Net MVC 5", AuthorName="Adam Freeman", Content="ASP.Net MVC 5 Framwork is the lastest evolution of Microsoft's ASP.NET wweb platform"},
        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault(s => s.Id == id);
            if (sach == null)
            {
                return  NotFound();
            }
            return Ok(sach);


        }
    }
}
