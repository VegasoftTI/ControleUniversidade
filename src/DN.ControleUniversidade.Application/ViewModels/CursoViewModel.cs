using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DN.ControleUniversidade.Application.ViewModels
{
    public class CursoViewModel
    {
        [HiddenInput(DisplayValue=false)]
        public Guid CursoId { get; set; }

        [Display(Name="Nome do Curso")]
        [Required(ErrorMessage="O campo Nome do Curso é obrigatório")]
        public string Descricao { get; set; }

        [Display(Name="Situação")]
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
