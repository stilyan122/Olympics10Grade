using ElementFactory.Data;
using ElementFactory.Data.Models;
using ElementFactory.Models.Flashcard;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElementFactory.Controllers
{
    [Authorize]
    public class FlashcardController:Controller
    {
        private readonly ApplicationDbContext data;

        private readonly UserManager<User> userManager;

        public FlashcardController(ApplicationDbContext _data
            ,UserManager<User> _userManager)
        {
            this.data = _data;
            this.userManager = _userManager;
        }

        public async Task<IActionResult> ViewAllFlashcards() 
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user != null)
            {
                var flashcards = await data
                 .Flashcards
                 .Where(x=>x.IsActive && x.UserId==user.Id)
                 .Select(fc => new FlashcardViewModel()
                    {
                      Id= fc.Id,
                      Title = fc.Title,
                      Content = fc.Content,
                      IsActive = fc.IsActive
                    })
                 .ToListAsync();

                return View(flashcards);
            }
            return RedirectToAction("Error");     
        }

        public IActionResult AddFlashcard()
            => View();

        [HttpPost]
        public async Task<IActionResult> AddFlashcard(FlashcardViewModel model)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if(user != null)
            {
                var flashcard = new Flashcard()
                {
                    Title = model.Title,
                    Content = model.Content,
                    UserId=user.Id

                };

                await data.Flashcards.AddAsync(flashcard);
                user.Flashcards.Add(flashcard);
                await data.SaveChangesAsync();
                return RedirectToAction("ViewAllFlashcards");
            }
            return RedirectToAction("Error");
            
           
        }

        public async Task<IActionResult> EditFlashcard(int id)
        {
            var flashcard = await data.Flashcards.FindAsync(id);
            if(flashcard != null)
            {
                return View(new FlashcardViewModel()
                {
                    Id = id,
                    Title = flashcard.Title,
                    Content = flashcard.Content,
                    IsActive = flashcard.IsActive
                });
            }
            return View("Error"); 
        }

        [HttpPost]
        public async Task<IActionResult> EditFlashcard
            (int id, FlashcardViewModel model)
        {
            var flashcard = await data.Flashcards.FindAsync(id);

            if (flashcard != null)
            {
                flashcard.Title = model.Title;
                flashcard.Content = model.Content;
                await data.SaveChangesAsync();
                return RedirectToAction("ViewAllFlashcards");
            }
            return View("Error");      
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFlashcard(int id)
        {
            var flashcard= await data.Flashcards.FindAsync(id);

            if (flashcard != null)
            {
                flashcard.IsActive = false;
                await data.SaveChangesAsync();
                return RedirectToAction("ViewAllFlashcards");
            }
            return View("Error");
        }
    }
}
