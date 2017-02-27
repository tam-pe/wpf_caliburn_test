// Caliburn.micro training developed for  Softeq Development Corporation
// http://www.softeq.com

using Ninject;
using WpfTraining.Service;
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
            kernel.Bind<IDataManager>().To<DataManager>();
            kernel.Bind<IUserManager>().To<UserManager>().InSingletonScope();
        }

        public T Create<T>()
        {
            return kernel.Get<T>();
        }
    }
}
