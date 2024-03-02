using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFactory.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
        }

        public bool IsRequested { get; set; }

        public bool IsActive {  get; set; }

        public int Points { get; set; }

        public List<Flashcard> Flashcards { get; set; } =new List<Flashcard>();
    }
}
