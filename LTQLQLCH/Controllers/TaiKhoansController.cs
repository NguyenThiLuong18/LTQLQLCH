using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LTQLQLCH.Models;
namespace LTQLMVC.Controllers
{
    public class TaiKhoansController : Controller
    {
        LTQLQLCHDbContext db = new LTQLQLCHDbContext();
        // GET: Home
        public ActionResult Index()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("DangNhap");
            }
        }

        //GET: Register

        public ActionResult DangKi()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKi(TaiKhoan acc)
        {
            if (ModelState.IsValid)
            {
                var check = db.TaiKhoans.FirstOrDefault(s => s.UserName == acc.UserName);
                if (check == null)
                {
                    acc.Password = GetMD5(acc.Password);
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.TaiKhoans.Add(acc);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Tên đăng nhập đã tồn tại.";
                    return View();
                }


            }
            return View();


        }

        public ActionResult DangNhap()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangNhap(string UserName, string Password, TaiKhoan acc)
        {
            if (ModelState.IsValid)
            {


                var f_password = GetMD5(Password);
                var data = db.TaiKhoans.Where(s => s.UserName.Equals(UserName) && s.Password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {

                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }


        //Logout
        public ActionResult DangXuat()
        {
            Session.Clear();//remove session
            return RedirectToAction("DangNhap");
        }



        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

    }
}
