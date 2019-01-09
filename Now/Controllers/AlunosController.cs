using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Now;

namespace Now.Controllers
{
    public class AlunosController : Controller
    {
        private Model2 db = new Model2();

        // GET: Alunos
        public ActionResult Index()
        {
            var alunos = db.Alunos.Include(a => a.Turmas);
            return View(alunos.ToList());
        }

        // GET: Alunos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alunos alunos = db.Alunos.Find(id);
            if (alunos == null)
            {
                return HttpNotFound();
            }
            return View(alunos);
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            ViewBag.Turma = new SelectList(db.Turmas, "Id_Turmas", "Turmas1");
            return View();
        }

        // POST: Alunos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Aluno,Turma,Nome")] Alunos alunos)
        {
            if (ModelState.IsValid)
            {
                db.Alunos.Add(alunos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Turma = new SelectList(db.Turmas, "Id_Turmas", "Turmas1", alunos.Turma);
            return View(alunos);
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alunos alunos = db.Alunos.Find(id);
            if (alunos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Turma = new SelectList(db.Turmas, "Id_Turmas", "Turmas1", alunos.Turma);
            return View(alunos);
        }

        // POST: Alunos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Aluno,Turma,Nome")] Alunos alunos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alunos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Turma = new SelectList(db.Turmas, "Id_Turmas", "Turmas1", alunos.Turma);
            return View(alunos);
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alunos alunos = db.Alunos.Find(id);
            if (alunos == null)
            {
                return HttpNotFound();
            }
            return View(alunos);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alunos alunos = db.Alunos.Find(id);
            db.Alunos.Remove(alunos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
