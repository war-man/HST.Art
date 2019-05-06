﻿using System.Web.Mvc;

namespace HST.Art.Web.Areas.manage
{
    public class manageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "manage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "manage_default",
                "manage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}