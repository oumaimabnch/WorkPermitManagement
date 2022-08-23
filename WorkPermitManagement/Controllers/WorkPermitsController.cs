using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkPermitManagement.Data;
using WorkPermitManagement.Data.services;
using WorkPermitManagement.Models;
using X.PagedList;
namespace WorkPermitManagement.Controllers
{
    public class WorkPermitsController : Controller
    {



        private readonly AppDbContext _context;

        public WorkPermitsController(AppDbContext context)
        {

            _context = context;
        }

        // GET: WorkPermits
        [Route("workpermits/")]
        public async Task<IActionResult> Index()
        {

            var result = await _context.WorkPermits.ToListAsync();

            return View(result);
        }


        //Get:WorkPermits/FilterWithDate/date1,date2
        [Route("workpermits/{dt1}/{dt2}")]
        public async Task<IActionResult> FilterWithDate(string dt1, string dt2)
        {
            string f = "yyyy-MM-dd";



            DateTime date1 = (DateTime)parseDate(dt1, f);
            DateTime date2 = (DateTime)parseDate(dt2, f);
            int testRes = DateTime.Compare(date1, date2);
            //var resultat= await _context.WorkPermits.Where(x =>  x.CONT_DATE_SAISIE >= date1 && x.CONT_DATE_SAISIE < date2).ToListAsync();
            var resultat = await _context.WorkPermits.Where(x => x.CONT_DATE_SAISIE.Value.Date >= date1.Date
            && x.CONT_DATE_SAISIE.Value.Date < date2.Date).ToListAsync();
            return View(resultat);


        }

        private DateTime? parseDate(string date, string format)
        {
            DateTime? dateTime = null;
            try
            {
                dateTime = DateTime.Parse(date);
                Console.WriteLine("The specified date is valid: " + dateTime);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse the specified date");
            }
            catch (ArgumentNullException)
            { }
            return dateTime;
        }




        // GET: WorkPermits/Details/5
        [Route("workpermits/Details/{id}")]
        public async Task<IActionResult> Details(int? id )
        {
           // var pageNumber = page ?? 1;
            //int pageSize = 10;
            if (id == null)
            {
                return NotFound();
            }

            var workPermit = await _context.WorkPermits.FirstOrDefaultAsync(m => m.id == id);
           // var workpermitpaginated = workPermit.ToPagedList(pageNumber,pageSize);

            if (workPermit == null)
            {
                return NotFound();
            }

            return View(workPermit);
        }

        // GET: WorkPermits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WorkPermits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

      
        public async Task<IActionResult> Create([Bind("id,CODE_CONT,CODE_DEM,CODE_REGIME,CODE_AVANT,CONT_CODE_CONTRAT,CONT_NATURE_CONTRAT,CONT_DATE_DEBUT,CONT_DATE_FIN,CONT_VAL_NOURRITURE,CONT_VAL_LOGEMENT,CONT_DATE_RESILIATION,CONT_CODE_ACT,CONT_CODE_CAS_SOC,CONT_CODE_DELEG,CONT_CODE_SIT_MAT,CONT_DATE_SAISIE,CONT_OBS,CONT_SALAIRE,CONT_CARTE_SEJOUR,CONT_EST_RESILIE,DATE_LIVRAISON,CONT_DATE_ENVOI_DR,CONT_UPDATE,CONT_PERSONNE,CONT_PERSONNE_L,CONT_PASSEPORT,CONT_NATIONALITE,CONT_NATIONALITE_L,CONT_FONCTION,CONT_FONCTION_L,CONT_CODE_ENT,CONT_CAT_ENT,CONT_EMPLOYEUR,CONT_EMPLOYEUR_L,CONT_EMPLOYEUR_ADR,CONT_EMPLOYEUR_ADR_L,CONT_NUM_CNSS,CONT_ACTIVITE,CONT_SIGNER,CONT_SIGNER_L,CONT_QRCODE_FR,CONT_QRCODE_AR,CONT_CODE_PERS,CONT_ETAT_PAIE,CONT_MODE_PAIE,CONT_REF_PAIE,CONT_DATE_PAIE,synched,CONT_CREATED_BY,CONT_ACTIVITE_L,CONT_UPDATED_BY")] WorkPermit workPermit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workPermit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workPermit);
        }
        [Route("workpermits/Edit/{id}")]

        // GET: WorkPermits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workPermit = await _context.WorkPermits.FindAsync(id);
            if (workPermit == null)
            {
                return NotFound();
            }
            return View(workPermit);
        }

        // POST: WorkPermits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,CODE_CONT,CODE_DEM,CODE_REGIME,CODE_AVANT,CONT_CODE_CONTRAT,CONT_NATURE_CONTRAT,CONT_DATE_DEBUT,CONT_DATE_FIN,CONT_VAL_NOURRITURE,CONT_VAL_LOGEMENT,CONT_DATE_RESILIATION,CONT_CODE_ACT,CONT_CODE_CAS_SOC,CONT_CODE_DELEG,CONT_CODE_SIT_MAT,CONT_DATE_SAISIE,CONT_OBS,CONT_SALAIRE,CONT_CARTE_SEJOUR,CONT_EST_RESILIE,DATE_LIVRAISON,CONT_DATE_ENVOI_DR,CONT_UPDATE,CONT_PERSONNE,CONT_PERSONNE_L,CONT_PASSEPORT,CONT_NATIONALITE,CONT_NATIONALITE_L,CONT_FONCTION,CONT_FONCTION_L,CONT_CODE_ENT,CONT_CAT_ENT,CONT_EMPLOYEUR,CONT_EMPLOYEUR_L,CONT_EMPLOYEUR_ADR,CONT_EMPLOYEUR_ADR_L,CONT_NUM_CNSS,CONT_ACTIVITE,CONT_SIGNER,CONT_SIGNER_L,CONT_QRCODE_FR,CONT_QRCODE_AR,CONT_CODE_PERS,CONT_ETAT_PAIE,CONT_MODE_PAIE,CONT_REF_PAIE,CONT_DATE_PAIE,synched,CONT_CREATED_BY,CONT_ACTIVITE_L,CONT_UPDATED_BY")] WorkPermit workPermit)
        {
            if (id != workPermit.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workPermit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkPermitExists(workPermit.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(workPermit);
        }

        // GET: WorkPermits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workPermit = await _context.WorkPermits
                .FirstOrDefaultAsync(m => m.id == id);
            if (workPermit == null)
            {
                return NotFound();
            }

            return View(workPermit);
        }

        // POST: WorkPermits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workPermit = await _context.WorkPermits.FindAsync(id);
            _context.WorkPermits.Remove(workPermit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkPermitExists(int id)
        {
            return _context.WorkPermits.Any(e => e.id == id);
        }
    }
}
