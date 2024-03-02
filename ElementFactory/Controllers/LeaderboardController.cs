using ElementFactory.Data.Models;
using ElementFactory.Models.Flashcard;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ElementFactory.Models;
using ElementFactory.Models.User;

namespace ElementFactory.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager;

        public LeaderboardController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public async Task<IActionResult> LoadLeaderboard()
        {
            var allUsers = await userManager.Users.ToListAsync();
            var usersNotInAdminRole = allUsers.Where(u => !userManager.IsInRoleAsync(u, "Admin").Result).ToList();
            var models = usersNotInAdminRole
                .Select(um => new LeaderUser()
                {
                    Id= um.Id,
                    Name = um.UserName,
                    Points = um.Points
                })
                .OrderByDescending(u => u.Points)
                .ToList();

            return View(models);
        }
    }
}
