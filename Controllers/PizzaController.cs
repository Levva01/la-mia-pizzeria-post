using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_post.Models;

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
    }
}