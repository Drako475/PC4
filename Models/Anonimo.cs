using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC4.Models
{
      [Table("t_datosAnonimos")]
    public class Anonimo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int id { get; set; }

        [Required(ErrorMessage="¡Espacio en blanco. Por favor ingrese su nombre!")]
        [Display(Name="comentario")]
        public string comentario{ get; set; }

        public DateTime addDate { get; set; }
    }
}