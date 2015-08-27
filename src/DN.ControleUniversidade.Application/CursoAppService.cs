using DN.ControleUniversidade.Application.Interfaces;
using DN.ControleUniversidade.Application.Mapper;
using DN.ControleUniversidade.Application.Validation;
using DN.ControleUniversidade.Application.ViewModels;
using DN.ControleUniversidade.Domain.Interfaces.Services;
using DN.ControleUniversidade.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN.ControleUniversidade.Application
{
    public class CursoAppService : AppServiceBase<UniversidadeContext>, ICursoAppService
    {
        private readonly ICursoService _cursoService;

        public CursoAppService(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }
        public ValidationAppResult AdicionarNovoCurso(CursoViewModel cursoViewModel)
        {
            var cursoDomain = CursoMapper.CursoViewModelParaCursoDomain(cursoViewModel);

            BeginTransaction();

            var validationAppResult = DomainToApplicationResult(_cursoService.AdicionarNovoCurso(cursoDomain));

            if (validationAppResult.IsValid)
                Commit();

            return validationAppResult;    
        }

        public IEnumerable<CursoViewModel> ObterTodos()
        {
            var cursosDb = _cursoService.ObterTodos();

            return CursoMapper.ListCursoParaListCursoViewModel(cursosDb);
          
        }

        public void Dispose()
        {
            _cursoService.Dispose();
        }
    }
}
