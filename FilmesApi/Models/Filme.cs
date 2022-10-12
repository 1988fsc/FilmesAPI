using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required (ErrorMessage = "Título obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Diretor obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Gênero maior que 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600 ,ErrorMessage = "Duração deve ser entre 1 e 600 min")]
        public int Duracao { get; set; }
        
    }

}
