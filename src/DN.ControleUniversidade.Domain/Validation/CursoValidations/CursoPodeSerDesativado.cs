using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Validation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN.ControleUniversidade.Domain.Validation.CursoValidations
{
    public class CursoPodeSerDesativado : FiscalBase<Curso>
    {
        public CursoPodeSerDesativado()
        {

        }
    }
}
