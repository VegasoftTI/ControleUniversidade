using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using DN.ControleUniversidade.Domain.Interfaces.Repositories;
using DN.ControleUniversidade.Domain.Entities;
using DN.ControleUniversidade.Domain.Validation.CursoValidations;

namespace DN.ControleUniversidade.Domain.Tests.Validations
{

    [TestClass]
    public class CursoValidationsTests
    {

        [TestMethod]
        [TestCategory("Validations Curso")]
        public void Um_Curso_Deve_Ser_Unico_No_BancoDeDados()
        {
            var curso = new Curso("Análise de Sistemas");
            var cursoResult = curso;

            var stubRepo = MockRepository.GenerateStub<ICursoRepository>();
            stubRepo.Stub(x => x.ObterPorDescricao(curso.Descricao)).Return(curso);

            var cursoValidation = new CursoEstaConsistente(stubRepo);
            var result = cursoValidation.Validar(curso);

            Assert.IsFalse(result.IsValid);
            Assert.IsTrue(result.Erros.Any(x => x.Message == "Este curso já foi cadastrado na base de dados"));
        }



    }
}
