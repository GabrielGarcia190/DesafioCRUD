using DesafioCRUD.Domain.Cliente.Repositories;
using DesafioCRUD.Infra;
using DesafioCRUD.Infra.Clientes.Repositories;
using Ninject;

namespace DesafioCRUD.Ioc
{
    public static class Config
    {
        private static IKernel? _kernel;

        public static IKernel Kernel
        {
            get
            {
                if (_kernel == null)
                {
                    return ConfigurarInjecao();
                }

                return _kernel;
            }
        }

        public static IKernel ConfigurarInjecao()
        {
            _kernel = new StandardKernel();

            ConfiguraBindings();

            return _kernel;
        }

        private static void ConfiguraBindings()
        {
            _kernel?.Bind<IClienteRepository>().To<ClienteRepository>();
            _kernel?.Bind<Configuracoes>().ToSelf().InSingletonScope();
        }
    }
}