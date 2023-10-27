using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Projeto_Autenticacao_Usuario__C_.Models
{

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public string UsuarioId { get; set; }


        [ForeignKey("UsuarioId")]
        public IdentityUser ContaIdentity { get; set; }


        [Required(ErrorMessage = "Insira o nome da área de atuação!")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }


        [StringLength(300)]
        public string FotoPerfil { get; set; }


        [Required(ErrorMessage = "Informe a Área de Atuação")]
        public int AreaAtuacaoId {get;set;}
        [ForeignKey("AreaAtuacaoId")]
        public AreaAtuacao AreaAtuacao {get; set;}
    }
}