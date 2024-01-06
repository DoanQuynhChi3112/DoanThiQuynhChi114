using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace DoanThiQuynhChi114.Controllers
{
    public class StringProcessDTQC114Controller : Controller
    {
        public IActionResult Index()
       {
        return View();
       }

       [HttpPost]
       public IActionResult Index(string fName , string ABC )
       {
        string strResult = "Hello" + fName.ToUpper() + "-" + ABC ;
        ViewBag.thongbao = strResult;
        return View();
       }
}
}
