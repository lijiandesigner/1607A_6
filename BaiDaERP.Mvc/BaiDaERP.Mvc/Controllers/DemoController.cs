using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiDaERP.Mvc.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login(string name, string pwd)
        {
            return View();
        }
        /// <summary>
        /// 员工信息显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Show()
        {
            return View();
        }
        /// <summary>
        /// 员工入职
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmp(HttpPostedFileBase img)
        {
            string jue = Server.MapPath("~/Images/");
            string fileName = DateTime.Now.ToString("yyyyMMddhh") + img.FileName;
            img.SaveAs(jue+fileName);
            //把路径保存到数据库里
            return View();
        }
        /// <summary>
        /// 员工调动表
        /// </summary>
        /// <returns></returns>
        public ActionResult EmpTransfer()
        {
            return View();
        }
    }
}