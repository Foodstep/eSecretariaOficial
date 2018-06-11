using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eSecretaria.Models;

namespace eSecretaria.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Cadastrar (ALUNO aluno)
        {
            try
            {
                if(aluno is ALUNO)
                {
                    eSecretariaEntities context = new eSecretariaEntities();
                    context.ALUNO.Add(aluno);
                    context.SaveChanges();
                }
                else
                {
                    return Json(new ClasseRespostaCreate()
                    {
                        success = false,
                        message = "Erro ao criar aluno - cod 1"
                    });
                }

                return Json(new ClasseRespostaCreate() {
                    success = true,
                    message = "Aluno criado com sucesso"
                });
            }catch(Exception ex)
            {
                return Json(new ClasseRespostaCreate()
                {
                    success = false,
                    message = "Erro ao criar aluno - cod 2"
                });
            }
        }

        public JsonResult GetAll()
        {
            try
            {
                eSecretariaEntities context = new eSecretariaEntities();


                return Json(new JsonRetorno() { data = context.ALUNO.ToList() });
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
    }
}