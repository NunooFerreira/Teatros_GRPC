using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Models
{
    [Table("teatro")]
    public partial class Teatro
    {
        public Teatro()
        {
            RegistaEspetaculos = new HashSet<RegistaEspetaculo>();
        }

        [Key]
        [Column("id_teatro")]
        public int IdTeatro { get; set; }
        [Required]
        [Column("nome_teatro")]
        [StringLength(30)]
        public string NomeTeatro { get; set; }
        [Required]
        [Column("morada_teatro")]
        [StringLength(50)]
        public string MoradaTeatro { get; set; }
        [Required]
        [Column("localizacao")]
        [StringLength(30)]
        public string Localizacao { get; set; }
        [Column("telemovel")]
        public int Telemovel { get; set; }
        [Column("telefone")]
        public int Telefone { get; set; }
        [Required]
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }

        [InverseProperty(nameof(RegistaEspetaculo.IdTeatroNavigation))]
        public virtual ICollection<RegistaEspetaculo> RegistaEspetaculos { get; set; }
    }
}
