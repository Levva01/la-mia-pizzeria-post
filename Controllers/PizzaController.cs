using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_post.Models;
using Microsoft.IdentityModel.Tokens;

namespace la_mia_pizzeria_post.Controllers
{
    public class PizzaController : Controller
    {
        private readonly List<Pizza> _pizze = new()
        {
        new Pizza
        {
            Id = 1,
            Nome = "Margherita",
            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
            Foto = "img/pizza.jpg",
            Prezzo = 5.00
        },

        new Pizza
        {
            Id = 2,
            Nome = "Margherita",
            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
            Foto = "img/pizza.jpg",
            Prezzo = 5.00
        },

        new Pizza
        {
            Id = 3,
            Nome = "Margherita",
            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
            Foto = "img/pizza.jpg",
            Prezzo = 5.00
        },

        new Pizza
        {
            Id = 4,
            Nome = "Margherita",
            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
            Foto = "img/pizza.jpg",
            Prezzo = 5.00
        },

        new Pizza
        {
            Id = 5,
            Nome = "Margherita",
            Descrizione = "Pom. San Marzano D.O.P, Fior di Latte , Olio Evo",
            Foto = "img/pizza.jpg",
            Prezzo = 5.00
        },
    };
        public IActionResult Index()
        {
            return View(_pizze);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza formPizza)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                Pizza pizzaCreate = new Pizza();
                pizzaCreate.Nome = formPizza.Nome;
                pizzaCreate.Descrizione = formPizza.Descrizione;
                pizzaCreate.Foto = formPizza.Foto;
                pizzaCreate.Prezzo = formPizza.Prezzo;

                context.Pizze.Add(pizzaCreate);

                context.SaveChanges();

                return RedirectToAction("Pizza");
            }
    
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}