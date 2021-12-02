using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogodejogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter de 3 a 100 caracteres")]

        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 3 a 100 caracteres")]

        public string Produtora { get; set; }
        [Required]
        [Range(5, 1000, ErrorMessage = "O preço deve ser no mínimo 5 reais e no máximo 1000 reais")]

        public double Preco { get; set; }

    }
}
