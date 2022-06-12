using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Models
{
    [Table("Utilizador")]
    public partial class Utilizador
    {
        public Utilizador()
        {
            ComprarBilhetes = new HashSet<ComprarBilhete>();
        }

        [Key]
        [Column("id_utilizador")]
        public int IdUtilizador { get; set; }
        [Required]
        [Column("username")]
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [Column("pass")]
        [StringLength(30)]
        public string Pass { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [Column("nif")]
        [StringLength(9)]
        public string Nif { get; set; }
        [Column("idade")]
        public int Idade { get; set; }
        [Required]
        [Column("localidade")]
        [StringLength(50)]
        public string Localidade { get; set; }

        [Column("saldo", TypeName = "money")]
        public decimal Saldo { get; set; }
        [Column("movimentos")]
        [StringLength(150)]
        public string Movimentos { get; set; }

        [Column("id_tipo_utilizador")]
        public int? Tipoutilizador { get; set; }

        [InverseProperty(nameof(ComprarBilhete.IdUtilizadorNavigation))]
        public virtual ICollection<ComprarBilhete> ComprarBilhetes { get; set; }
    }
}
