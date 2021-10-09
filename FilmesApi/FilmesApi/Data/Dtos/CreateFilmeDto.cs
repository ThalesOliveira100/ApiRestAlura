using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "Campo titulo obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo diretor obrigatorio")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O genero nao pode ultrapassar 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "Duracao deve estar entre 1 a 600")]
        public int Duracao { get; set; }
    }
}
