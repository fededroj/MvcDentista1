using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcDentista1.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 3)]
        public string Nombre { get; set; }


        [StringLength(18, MinimumLength = 3)]
        public string Apellido { get; set; }


        [Display(Name = "Última Asistencia"), DataType(DataType.DateTime)]
        public DateTime FechaAsistencia { get; set; }


        /*[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(10)]*/
        public string Domicilio { get; set; }


        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(16)]
        public string Localidad { get; set; }

        public int Edad { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(15, MinimumLength =5)]
        public string ObraSocial { get; set; }
    }
}
