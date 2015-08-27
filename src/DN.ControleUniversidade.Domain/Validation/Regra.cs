using DN.ControleUniversidade.Domain.Interfaces.Specification;
using DN.ControleUniversidade.Domain.Interfaces.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN.ControleUniversidade.Domain.Validation
{
    public class Regra<TEntity> : IRegra<TEntity>
    {
        private readonly ISpecification<TEntity> _specificationRule;
        public string MensagemErro { get; private set; }

        public Regra(ISpecification<TEntity> regra, string mensagemErro)
        {
            this._specificationRule = regra;
            this.MensagemErro = mensagemErro;
        }

        public bool Validar(TEntity entity)
        {
            return this._specificationRule.IsSatisfiedBy(entity);
        }
    }
}
