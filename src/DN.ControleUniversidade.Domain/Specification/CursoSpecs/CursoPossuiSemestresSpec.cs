using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Interfaces.Specification;
using System.Linq;

namespace DN.ControleUniversidade.Domain.Specification.CursoSpecs
{
    public class CursoPossuiSemestresSpec: ISpecification<Curso>
    {
        public bool IsSatisfiedBy(Curso curso)
        {
            return curso.Semestres != null && curso.Semestres.Any();
        }
    }
}
