using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcDentista1.Models
{
    public class OSBuscaViewModel
    {
        public List<Paciente> Pacientes { get; set; }
        public SelectList ObraSocial { get; set; }
        public string OSPaciente { get; set; }
        public string SearchString { get; set; }
    }
}
