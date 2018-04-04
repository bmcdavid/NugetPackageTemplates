using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace EpiserverTemplate
{
    /// <summary>
    /// Example Module
    /// </summary>
    [InitializableModule]
    public class ExampleModule : IInitializableModule
    {
        /// <summary>
        /// Init
        /// </summary>
        /// <param name="context"></param>
        public void Initialize(InitializationEngine context)
        {
        }

        /// <summary>
        /// Uninit
        /// </summary>
        /// <param name="context"></param>
        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}
