using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Specification.MateriaSpecs;
using DN.ControleUniversidade.Domain.Validation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN.ControleUniversidade.Domain.Validation.MateriaValidations
{
    public class MateriaEstaAptaParaCadastro : FiscalBase<Materia>
    {
        public MateriaEstaAptaParaCadastro()
        {
            var materiaDescricao = new DescricaoEstaValidaSpecification();

            base.AdicionarRegra("DescricaoInvalida", new Regra<Materia>(materiaDescricao, "A descrição deve conter entre 5 e 50 caracteres"));
        }
    }
}
