using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Specification.CursoSpecs;
using DN.ControleUniversidade.Domain.Validation.Base;

namespace DN.ControleUniversidade.Domain.Validation.CursoValidations
{
    public class CursoEstaAptoParaAtivacao : FiscalBase<Curso>
    {
        public CursoEstaAptoParaAtivacao()
        {
            var cursoSemestre = new CursoPossuiSemestresSpec();
            var cursoNumeroMinimoSemestre = new PossuiNumeroMinimoSemestresSpec();

            base.AdicionarRegra("CursoSemSemestre", new Regra<Curso>(cursoSemestre, "O curso não possui nenhum semestre"));
            base.AdicionarRegra("cursoNumeroMinimoSemestre", new Regra<Curso>(cursoNumeroMinimoSemestre, "O curso deve possuir pelo menos 4 semestres"));
        }
    }
}
