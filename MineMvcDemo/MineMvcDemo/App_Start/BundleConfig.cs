using System.Web;
using System.Web.Optimization;

namespace MineMvcDemo
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 https://modernizr.com 上的生成工具仅选择所需的测试。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/plugins/jquery/jquery-{version}.js",
                    "~/Scripts/plugins/layui/layui.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include
                ("~/Content/css/base.css",
                "~/Scripts/plugins/layui/css/layui.css"
                ));

            //可以覆盖web.config中compilation标签的设置
            //<compilation debug="true" targetFramework="4.6.1"/>
            //启用压缩、打包
            //BundleTable.EnableOptimizations = true;
        }
    }
}
