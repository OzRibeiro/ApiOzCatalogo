using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOzCatalogo.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(200, MinimumLength = 3, ErrorMessage =  "Nome no minimo 3 carecteres e no máximo 200, informando o jogo")]
        public string Nome { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "Nome no minimo 3 carecteres e no máximo 150, informando a produtora")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 2000, ErrorMessage = "Valor minimo 1 real e no máximo 2000")]
        public double Preco { get; set; }
    }
    
}
