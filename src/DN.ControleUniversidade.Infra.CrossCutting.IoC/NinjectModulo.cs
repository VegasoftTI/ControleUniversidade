using DN.ControleUniversidade.Application;
using DN.ControleUniversidade.Application.Interfaces;
using DN.ControleUniversidade.Domain.Interfaces.Repositories;
using DN.ControleUniversidade.Domain.Interfaces.Services;
using DN.ControleUniversidade.Domain.Services;
using DN.ControleUniversidade.Infra.Data.Context;
using DN.ControleUniversidade.Infra.Data.Interfaces;
using DN.ControleUniversidade.Infra.Data.Repositories;
using DN.ControleUniversidade.Infra.Data.UnitOfWork;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN.ControleUniversidade.Infra.CrossCutting.IoC
{
    class NinjectModulo: NinjectModule
    {
        public override void Load()
        {

            Bind<ICursoAppService>().To<CursoAppService>();

            Bind<ICursoService>().To<CursoService>();

            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<,>));
            Bind<ICursoRepository>().To<CursoRepository>();

            Bind(typeof(IContextManager<>)).To(typeof(ContextManager<>));
            Bind<IDbContext>().To<UniversidadeContext>();
            Bind(typeof(IUnitOfWork<>)).To(typeof(UnitOfWork<>));
        }
    }
}
