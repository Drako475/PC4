using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC4.Models
{
      [Table("t_datos")]
    public class Datos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int id { get; set; }

        [Required(ErrorMessage="¡Espacio en blanco. Por favor ingrese su nombre!")]
        [Display(Name="Titulo")]
        public string titulo{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco. Por favor ingrese su teléfono!")]
        [Display(Name="Usuario")]
        public string usuario{ get; set; }

        [Required(ErrorMessage="¡Espacio en blanco, Ingrese una url correcta!")]
        [Display(Name="URL de la foto")]
        public string url_foto{ get; set; }

        public DateTime addDate { get; set; }
    }
}