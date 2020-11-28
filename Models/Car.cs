using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorADS.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Informe o modelo")]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "Informe o código")]
        [DisplayName("Código")]
        public string CodigoCarro { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe o ano de fabricação")]
        [DisplayName("Ano Fabricação")]
        public string Ano { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe a kilometragem")]
        [DisplayName("Kilometragem")]
        public string Kilometragem { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe o vendedor")]
        [DisplayName("Vendedor")]
        public string Vendedor { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe as caracteristicas")]
        [DisplayName("Caracteristicas Gerais")]
        public string Caracteristica { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe a marca")]
        [DisplayName("Marca")]
        public string Marca { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Informe a cor")]
        [DisplayName("Cor")]
        public string Cor { get; set; }
    }
}
