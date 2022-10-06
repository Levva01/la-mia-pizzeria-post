﻿using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_post.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Foto { get; set; }
        public double Prezzo { get; set; }

        public Pizza()
        {

        }
    }
}