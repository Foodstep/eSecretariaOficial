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
            ViewBag.TodosProfessores = context.PROFESSOR.Select(x => new BaseCombo()
            {
                text = x.NOME_PROFESSOR,
                value = x.ID_PROFESSOR.ToString()
            }).ToList();
            ViewBag.TodosAlunos = context.ALUNO.Select(x => new BaseCombo()
            {
                text = x.NOME_ALUNO,
                value = x.ID_ALUNO.ToString()
            }).ToList();
            return View();
        }

        public JsonResult MarcarAula(MarcarAula aula)
        {
            try
            {
                eSecretariaEntities context = new eSecretariaEntities();
                AULA aulaDb = new AULA();
                //testenado git
                aulaDb.DATA_AULA = aula.data;
                aulaDb.PROFESSOR = context.PROFESSOR.FirstOrDefault();
                aulaDb.HORA_FIM = TimeSpan.Parse(aula.fim);
                aulaDb.HORA_INICIO = TimeSpan.Parse(aula.inicio);

                aulaDb.ALUNO = context.ALUNO.Where(x => aula.alunos.Contains(x.ID_ALUNO)).ToList();
                context.AULA.Add(aulaDb);
                context.SaveChanges();
                return Json(new ClasseRespostaCreate()
                {
                    success = true,
                    message = "Aula marcada com sucesso"
                });
            }
            catch (Exception ex)
            {
                return Json(new ClasseRespostaCreate()
                {
                    success = false,
                    message = "Erro ao criar aluno - cod 2"
                });
            } 
            
        }

        [HttpGet]
        public JsonResult GetAulas(int professor)
        {
            eSecretariaEntities context = new eSecretariaEntities();
            List<AULA> listaAulas =  context.AULA.Where(x=> x.PROFESSOR.ID_PROFESSOR == professor).ToList();

            
            var aulas = listaAulas.Select(x => new JsonAula()
            {
                allDay = false,
                start = x.DATA_AULA.ToString("yyyy-MM-dd") + "T" + x.HORA_INICIO.ToString(),
                end = x.DATA_AULA.ToString("yyyy-MM-dd") + "T" + x.HORA_FIM.ToString(),
                title = "Aula teste"
            }).ToList();

            return Json(aulas,JsonRequestBehavior.AllowGet);

        }
    }
}