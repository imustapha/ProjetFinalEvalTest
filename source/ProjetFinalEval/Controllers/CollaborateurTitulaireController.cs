using ProjetFinalEval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AppGestionEvaluation.Controllers
{
    public class CollaborateurTitulaireController : Controller
    {
        bd_evaluationEntities3 bd = new bd_evaluationEntities3();
        // GET: Collaborateur
        public ActionResult Index()
        {
            return View(bd.collaborateurtitulaire.ToList());
        }

        // GET: Collaborateur/Details/5
        public ActionResult Details(int? id)
        {
            ViewBag.Evaluateur = bd.collaborateurtitulaire.Where(m => m.IDCOLLABORATEURTITULAIRE == id).FirstOrDefault().FLAGEVAL;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            collaborateurtitulaire CollT = bd.collaborateurtitulaire.Find(id);
            if (CollT == null)
            {
                return HttpNotFound();
            }
            return View(CollT);
        }
        [HttpGet]
        // GET: Collaborateur/Create
        public ActionResult Create()
        {
            ViewBag.IDFONCTION = new SelectList(bd.fonction, "IDFONCTION", "NOMFONCTION");
            return View();
        }

        // POST: Collaborateur/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "IDCOLLABORATEUR,IDFONCTION,NOM,PRENOM,EMAIL,IMAGE,FLAGEVAL")] collaborateurtitulaire CollT)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    bd.collaborateurtitulaire.Add(CollT);
                    int x = bd.SaveChanges();
                    return RedirectToAction("Index");
                }
                else if (!ModelState.IsValid)
                {
                    ViewBag.IDFONCTION = new SelectList(bd.fonction, "IDFONCTION", "NOMFONCTION");
                    return View(CollT);
                }
            }
            catch (Exception ex)
            {
                ViewBag.IDFONCTION = new SelectList(bd.fonction, "IDFONCTION", "NOMFONCTION");
                string tst = ex.Message;
                return View();
            }
            ViewBag.IDFONCTION = new SelectList(bd.fonction, "IDFONCTION", "NOMFONCTION");
            return View();
        }

        // GET: Collaborateur/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.IDFONCTION = new SelectList(bd.fonction, "IDFONCTION", "NOMFONCTION", bd.collaborateurtitulaire.Find(id).fonction.IDFONCTION);
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            collaborateurtitulaire CollT = bd.collaborateurtitulaire.Find(id);
            if (CollT == null)
                return HttpNotFound();
            return View(CollT);
        }

        // POST: Collaborateur/Edit/5
        [HttpPost]
        public ActionResult Edit(collaborateurtitulaire CollT)
        {
            ViewBag.IDFONCTION = new SelectList(bd.fonction, "IDFONCTION", "NOMFONCTION");
            try
            {
                if (ModelState.IsValid)
                {
                    bd.Entry(CollT).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CollT);
            }
            catch
            {
                return View();
            }
        }

        // GET: Collaborateur/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            collaborateurtitulaire CollT = bd.collaborateurtitulaire.Find(id);
            if (CollT == null)
            {
                return HttpNotFound();
            }
            return View(CollT);
        }

        // POST: Collaborateur/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, collaborateurtitulaire CollTt)
        {
            try
            {
                collaborateurtitulaire CollT = new collaborateurtitulaire();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    CollT = bd.collaborateurtitulaire.Find(id);
                    if (CollT == null)
                        return HttpNotFound();
                    bd.collaborateurtitulaire.Remove(CollT);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CollT);
            }
            catch
            {
                return View();
            }
        }
    }
}