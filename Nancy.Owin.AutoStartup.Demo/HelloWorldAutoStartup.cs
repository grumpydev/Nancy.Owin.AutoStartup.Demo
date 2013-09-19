namespace Nancy.Owin.AutoStartup.Demo
{
    using System.Collections.Generic;

    using global::Owin;
    using global::Owin.AutoStartup;

    // Uncomment this class to see the behaviour when AutoStartups clash

    //public class HelloWorldAutoStartup : IAutoStartup
    //{
    //    public string Name
    //    {
    //        get
    //        {
    //            return "HelloWorld";
    //        }
    //    }

    //    public string Path
    //    {
    //        get
    //        {
    //            return "/";
    //        }
    //    }

    //    public IDictionary<string, object[]> DefaultBuilderCommands { get; private set; }

    //    public void Configuration(IAppBuilder builder)
    //    {
    //        builder.UseHandlerAsync((req, res) =>
    //        {
    //            res.ContentType = "text/plain";
    //            return res.WriteAsync("Hello, World!");
    //        });
    //    }
    //}
}