using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Interfaces.Specification;

namespace DN.ControleUniversidade.Domain.Specification.CursoSpecs
{
    public class PossuiNumeroMinimoSemestresSpec : ISpecification<Curso>
    {
        public bool IsSatisfiedBy(Curso curso)
        {
            return curso.Semestres != null && curso.Semestres.Count >= 4;
        }
    }
}
