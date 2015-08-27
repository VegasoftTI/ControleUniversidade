using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Interfaces.Specification;

namespace DN.ControleUniversidade.Domain.Specification.MateriaSpecs
{
    public class DescricaoEstaValidaSpecification : ISpecification<Materia>
    {
        public bool IsSatisfiedBy(Materia materia)
        {
            if (!string.IsNullOrEmpty(materia.Descricao))
            {
                return materia.Descricao.Length > 5 && materia.Descricao.Length < 50;
            }
            return false;
        }
    }
}
