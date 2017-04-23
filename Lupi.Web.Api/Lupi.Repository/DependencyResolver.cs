using Lupi.DependencyResolver;
using System.ComponentModel.Composition;

namespace Lupi.Repository
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IBreedsRepository, BreedsRepository>();
        }
    }
}

