using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Sistema_de_reserva_bilhetes.Models
{
    [Table("sessao")]
    public partial class Sessao
    {
        public Sessao()
        {
            RegistaEspetaculos = new HashSet<RegistaEspetaculo>();
        }

        [Key]
        [Column("id_sessao")]
        public int IdSessao { get; set; }

        [StringLength(30)]
        public string NomeSessao { get; set; }

        [Column("data_sessao", TypeName = "date")]
        public DateTime DataSessao { get; set; }
        [Column("hora_inicio")]
        public string HoraInicio { get; set; }
        [Column("hora_fim")]
        public string HoraFim { get; set; }
        [Column("lugar_totais")]
        public int LugarTotais { get; set; }
        [Column("lugares_disponiveis")]
        public int LugaresDisponiveis { get; set; }

        [InverseProperty(nameof(RegistaEspetaculo.IdSessaoNavigation))]
        public virtual ICollection<RegistaEspetaculo> RegistaEspetaculos { get; set; }
    }
}
