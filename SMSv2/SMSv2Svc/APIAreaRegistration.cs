using System.Web.Mvc;

namespace SMSv2Svc
{
    public class ApiAreaRegistration : AreaRegistration
    {
        public override string AreaName { get { return "v1"; } }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SingleComment",
                "v1/Comments/Comment/{id}",
                new
                {
                    controller = "Comments",
                    action = "Comment",
                    id = UrlParameter.Optional
                }
            );
            context.MapRoute(
                "ListComments",
                "v1/Comments/{page}/{count}",
                new
                {
                    controller = "Comments",
                    action = "CommentList",
                    page = UrlParameter.Optional,
                    count = UrlParameter.Optional
                }
            );
            context.MapRoute(
                "ListCommentsAll",
                "v1/Comments",
                new
                {
                    controller = "Comments",
                    action = "CommentList",
                    page = UrlParameter.Optional,
                    count = UrlParameter.Optional
                }
            );

            context.MapRoute(
                "Api_default",
                "v1/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}