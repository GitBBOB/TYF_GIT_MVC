using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TF_Homes_HMVC.Controllers
{
    public class UserpageController : Controller
    {

        #region 首页
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        #endregion
        #region 登录

        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {

            return View();

        }
        #endregion
        /// <summary>
        /// 测试 页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Test()
        {

            return View();
        }
    }
}