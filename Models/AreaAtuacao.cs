using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Autenticacao_Usuario__C_.Models
{
    [Table("Área_de_Atuacao")]
    public class AreaAtuacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira o nome da área de atuação!")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres!")]
        public string Nome { get; set; }

    }
}