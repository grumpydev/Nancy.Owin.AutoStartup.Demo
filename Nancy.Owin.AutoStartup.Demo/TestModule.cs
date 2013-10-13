namespace Nancy.Owin.AutoStartup.Demo
{
    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get["/"] = _ => View["index"];
        }
    }
}