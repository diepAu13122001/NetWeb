using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nail_Web.Data;
using Nail_Web.Models;

namespace Web.Controllers
{
    public class MyUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MyUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MyUsers
        public async Task<IActionResult> Index()
        {
              return _context.MyUser != null ? 
                          View(await _context.MyUser.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.User'  is null.");
        }

        // GET: MyUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MyUser == null)
            {
                return NotFound();
            }

            var myUser = await _context.MyUser
                .FirstOrDefaultAsync(m => m.Usr_Id == id);
            if (myUser == null)
            {
                return NotFound();
            }

            return View(myUser);
        }

        // GET: MyUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Usr_Id,Usr_FirstName,Usr_LastName,Usr_IsAdmin,Usr_UserName,Usr_Password,Usr_PhoneNum,Usr_Email,Usr_Gender")] MyUser myUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myUser);
        }

        // GET: MyUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MyUser == null)
            {
                return NotFound();
            }

            var myUser = await _context.MyUser.FindAsync(id);
            if (myUser == null)
            {
                return NotFound();
            }
            return View(myUser);
        }

        // POST: MyUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Usr_Id,Usr_FirstName,Usr_LastName,Usr_IsAdmin,Usr_UserName,Usr_Password,Usr_PhoneNum,Usr_Email,Usr_Gender")] MyUser myUser)
        {
            if (id != myUser.Usr_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyUserExists(myUser.Usr_Id))
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
            return View(myUser);
        }

        // GET: MyUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MyUser == null)
            {
                return NotFound();
            }

            var myUser = await _context.MyUser
                .FirstOrDefaultAsync(m => m.Usr_Id == id);
            if (myUser == null)
            {
                return NotFound();
            }

            return View(myUser);
        }

        // POST: MyUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MyUser == null)
            {
                return Problem("Entity set 'ApplicationDbContext.User'  is null.");
            }
            var myUser = await _context.MyUser.FindAsync(id);
            if (myUser != null)
            {
                _context.MyUser.Remove(myUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyUserExists(int id)
        {
          return (_context.MyUser?.Any(e => e.Usr_Id == id)).GetValueOrDefault();
        }
    }
}
