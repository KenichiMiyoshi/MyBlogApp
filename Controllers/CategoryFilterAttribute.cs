using MyBlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogApp.Controllers
{
    [AttributeUsage(AttributeTargets.Class)]
    //FilterAttributeクラスとIActionFilterインターフェースの実装
    public class CategoryFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //コンテキストクラスのインスタンス取得
            using (var db = new BlogContext())
            {
                // Categoryのコレクションを取得
                var categories = db.Categories.OrderByDescending(item => item.Count).ToList();
                // ViewBagにcategoriesのデータを保持
                filterContext.Controller.ViewBag.Categories = categories;
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }
    }
}