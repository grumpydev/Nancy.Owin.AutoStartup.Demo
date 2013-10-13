namespace Nancy.Owin.AutoStartup.Demo
{
    using System.Collections.Generic;
    using System.Linq;

    using global::Owin;
    using global::Owin.AutoStartup;

    // Uncomment the interface implementation in this class to see the behaviour when AutoStartups clash

    public class HelloWorldAutoStartup// : IAutoStartup
    {
        public string Name
        {
            get
            {
                return "HelloWorld";
            }
        }

        public string Path
        {
            get
            {
                return "/";
            }
        }

        public IEnumerable<string> DefaultBuilderCommands { get { return Enumerable.Empty<string>(); } }

        public void Configuration(IAppBuilder builder)
        {
            builder.UseHandlerAsync((req, res) =>
            {
                res.ContentType = "text/plain";
                return res.WriteAsync("Hello, World!");
            });
        }
    }
}