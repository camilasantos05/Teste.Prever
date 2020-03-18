using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPI.Shared;

namespace WebAPI.Domain
{
    public class Cotacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string AeroportoOrigem { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string AeroportoDestino { get; set; }

        [Required]
        [Column(TypeName = "DateTime2")]
        public DateTime DataSaida { get; set; }

        [Required]
        [Column(TypeName = "DateTime2")]
        public DateTime DataRetorno { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int QuantidadePessoas { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Observacao { get; set; }

        public EnumStatusCotacao Status { get; set; }
    }
}