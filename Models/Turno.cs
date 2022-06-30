using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcDentista1.Models
{
    public class Turno
    {
        public int Id { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 3)]
        public string Apellido { get; set; }

        
        //[Required]/*
       // [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(30, MinimumLength =9)]*/
       
        public string CorreoElectronico { get; set; }


        [Display(Name = "Fecha del Turno"), DataType(DataType.DateTime)]
        /*[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(20)]
        */
        public DateTime FechaTurno { get; set; }

       // [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(20)]
        public string Comentario { get; set; }
    }
}
