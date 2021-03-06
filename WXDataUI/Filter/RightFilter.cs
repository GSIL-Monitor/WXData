﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WXDataModel;
using WXDataModel.Extend;

namespace WXDataUI.Filter
{
    public class RightFilter:ActionFilterAttribute
    {
        public string Message { get; set; }

        private string ReturnMsg = "<script> alert('权限不足!');location.href='/Base/Home/Index'; </script>";

        /// <summary>
        /// Action执行之前调用
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            SYS_Role role = (filterContext.HttpContext.Session["SYSUSER"] as SYS_User).SYS_Role;
            if (!role.RoleSign.Equals("SYS_ADMIN"))
            {
                if (!role.CheckRight(Message))
                {
                    filterContext.HttpContext.Response.Write(ReturnMsg);
                }
            }
            //filterContext.HttpContext.Response.Write("Action执行之前" + Message + "<br />");
        }
        /// <summary>
        /// Action执行之后调用
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            //filterContext.HttpContext.Response.Write("Action执行之后" + Message + "<br />");
        }
        /// <summary>
        /// 返回结果之前调用
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            //filterContext.HttpContext.Response.Write("返回Result之前" + Message + "<br />");
        }
        /// <summary>
        /// 返回结果之后调用
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            //filterContext.HttpContext.Response.Write("返回Result之后" + Message + "<br />");
        }
    }
}