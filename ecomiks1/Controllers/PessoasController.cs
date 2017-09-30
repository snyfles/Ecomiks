using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ecomiks1.Models;

namespace ecomiks1.Controllers
{
    public class PessoasController : Controller
    {
        private Context db = new Context();

        // GET: Pessoas
        public ActionResult Index()
        {
            
            var pessoas = db.Pessoas.Include(p => p.Perfil);
            return View(pessoas.ToList());
        }

        // GET: Pessoas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // GET: Pessoas/Create
        public ActionResult Create()
        {
           // ViewBag.PerfilID = new SelectList(db.Perfils, "PerfilID", "NomePerfil");
            return View();
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PessoaID,Nome,RG,DataNascimento,CPF,Email,Sexo,Rua,NumeroEndereco,Bairro,Cidade,DataHoraCadastro,SenhaAcesso")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                pessoa.DataHoraCadastro = DateTime.Now;
                pessoa.PerfilID = 7;
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.PerfilID = new SelectList(db.Perfils, "PerfilID", "NomePerfil", pessoa.PerfilID);
            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public ActionResult Edit(int? id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            ViewBag.PerfilID = new SelectList(db.Perfils, "PerfilID", "NomePerfil", pessoa.PerfilID);
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PessoaID,Nome,RG,DataNascimento,CPF,Email,Sexo,Rua,NumeroEndereco,Bairro,Cidade,DataHoraCadastro,SenhaAcesso,PerfilID")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PerfilID = new SelectList(db.Perfils, "PerfilID", "NomePerfil", pessoa.PerfilID);
            return View(pessoa);
        }

        public ActionResult EditComum(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            //ViewBag.PerfilID = new SelectList(db.Perfils, "PerfilID", "NomePerfil", pessoa.PerfilID);
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditComum([Bind(Include = "PessoaID,Nome,RG,DataNascimento,CPF,Email,Sexo,Rua,NumeroEndereco,Bairro,Cidade,DataHoraCadastro,SenhaAcesso")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    pessoa.PerfilID = 7;
                    db.Entry(pessoa).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.InnerException.ToString());
                    throw;
                }
               
                return RedirectToAction("Index");
            }
            //ViewBag.PerfilID = new SelectList(db.Perfils, "PerfilID", "NomePerfil", pessoa.PerfilID);
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            db.Pessoas.Remove(pessoa);
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
