using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN.ControleUniversidade.Domain.Entities
{
    public class Semestre
    {
        public Semestre()
        {
            SemestreId = Guid.NewGuid();
        }
        public Guid SemestreId { get; protected set; }
        public int NumeroSemestre { get; protected set; }
    }
}
