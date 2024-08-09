﻿using System.ComponentModel.DataAnnotations;

namespace Imc.Models
{
    public class ImcModel
    {
        [Required(ErrorMessage = "Informe a Altura")]
        [Range(1,3, ErrorMessage = "Altura Inválida")]
        public double? Heigth { get; set; }

        [Required(ErrorMessage = "Informe o peso")]
        [Range(15, 300, ErrorMessage = "Peso Inválido")]
        public double? Weight { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public double Imc => (Weight ?? 1) / (Heigth ?? 1) * (Heigth ?? 1);
    }
}
