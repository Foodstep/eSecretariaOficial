using eSecretaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSecretaria.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            eSecretariaEntities context = new eSecretariaEntities();
            ViewBag.TodosAlunos = context.ALUNO.Select(x => new BaseCombo()
            {
                text = x.NOME_ALUNO,
                value = x.ID_ALUNO.ToString()
            }).ToList();
            return View();
        }

        public JsonResult MarcarAula(MarcarAula aula)
        {
            eSecretariaEntities context = new eSecretariaEntities();
            AULA aulaDb = new AULA();
            //testenado git
            aulaDb.PROFESSOR = context.PROFESSOR.FirstOrDefault();
            aulaDb.HORA_FIM = TimeSpan.Parse(aula.fim);
            aulaDb.HORA_INICIO = TimeSpan.Parse(aula.inicio);

            aulaDb.ALUNO = context.ALUNO.Where(x => aula.alunos.Contains(x.ID_ALUNO)).ToList();
            context.AULA.Add(aulaDb);
            context.SaveChanges();
            return Json(new ClasseRespostaCreate()
            {
                success = false,
                message = "Erro ao criar aluno - cod 2"
            });
        }
    }
}