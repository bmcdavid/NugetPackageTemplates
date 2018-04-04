using DotNetStarter.Abstractions;

namespace DotNetStarterRegistrationTemplate
{
    /// <summary>
    /// Default implementation
    /// </summary>
    [Registration(typeof(IExampleService))]
    public class ExampleService : IExampleService
    {
        /// <summary>
        /// Says Hi
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string SayHi(string name)
        {
            return "Hello " + name;
        }
    }
}
