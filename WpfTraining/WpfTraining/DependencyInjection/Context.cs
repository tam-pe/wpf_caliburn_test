// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using Ninject;
using WpfTraining.Service.Interface;

namespace WpfTraining.DependencyInjection
{
    internal class Context
    {
        StandardKernel kernel;

        public Context(INavigator navigator)
        {
            kernel = new StandardKernel();
            kernel.Bind<INavigator>().ToConstant(navigator).InSingletonScope();
        }

        public T Create<T>()
        {
            return kernel.Get<T>();
        }
    }
}
