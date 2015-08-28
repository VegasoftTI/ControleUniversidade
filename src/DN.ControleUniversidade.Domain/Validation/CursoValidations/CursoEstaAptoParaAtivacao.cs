using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Specification.CursoSpecs;
using DN.ControleUniversidade.Domain.Validation.Base;

namespace DN.ControleUniversidade.Domain.Validation.CursoValidations
{
    public class CursoEstaAptoParaAtivacao : FiscalBase<Curso>
    {
        public CursoEstaAptoParaAtivacao()
        {
            var cursoNumeroMinimoSemestre = new PossuiNumeroMinimoSemestresSpec();
            base.AdicionarRegra("cursoNumeroMinimoSemestre", new Regra<Curso>(cursoNumeroMinimoSemestre, "O curso deve possuir pelo menos 4 semestres para poder ser ativado"));
        }
    }
}
