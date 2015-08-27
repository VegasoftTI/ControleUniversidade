using DN.ControleUniversidade.Domain.Interfaces.Validation;
using DN.ControleUniversidade.Domain.Validation.MateriaValidations;
using DN.ControleUniversidade.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace DN.ControleUniversidade.Domain.Entities
{
    public class Materia : ISelfValidator
    {
        protected Materia()
        {

        }
        public Materia(string descricao)
        {
            MateriaId = Guid.NewGuid();
            Semestres = new List<Semestre>();
        }

        public Guid MateriaId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Semestre> Semestres { get; set; }
        public ValidationResult ResultadoValidacao { get; private set; }

        public bool IsValid
        {
            get { return ResultadoValidacao.IsValid; }
        }
    }
}
