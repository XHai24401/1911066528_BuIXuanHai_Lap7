using _1911066528_BuIXuanHai_Lap7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911066528_BuIXuanHai_Lap7.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach{Id=1,Title="Tôi thấy hoa vàng trên cở xanh",AuthorName="Nguyễn Nhật Ánh",Price=1,Content="Truyện kể về tuổi thơ...."},
            new Sach{Id=2,Title="Pro ASP.Net",AuthorName="Adam Freeeman",Content="The ASP.NET MVC 5 Framework is the latest....",Price=3.75M}
        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
            {
                return NotFound();
                
            }
            return Ok(sach);
        }
    }
}
