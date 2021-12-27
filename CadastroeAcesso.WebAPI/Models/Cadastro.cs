using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroeAcesso.WebAPI.Models
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(150)")]
        public string FullName { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(150)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string BornDate { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? Number { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
      
    }
}
