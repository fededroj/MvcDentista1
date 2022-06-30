using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcDentista1.Data;
using System;
using System.Linq;


namespace MvcDentista1.Models

{

    public static class SeedData

    {

        public static void Initialize(IServiceProvider serviceProvider)

        {

            using (var context = new MvcDentista1Context(

                serviceProvider.GetRequiredService<

                    DbContextOptions<MvcDentista1Context>>()))

            {

                // Look for any movies.

                if (context.Paciente.Any())

                {
                    return;   // DB has been seeded
                }

                if (context.Diente.Any())

                {
                    return;  
                }

                if (context.Turno.Any())

                {
                    return;   // DB has been seeded
                }

                context.Paciente.AddRange(

                    new Paciente

                    {
                        Nombre = "Juan",
                        Apellido = "Pintos",
                        FechaAsistencia = DateTime.Parse("22-5-2022 14:00:00.000+01:00"),
                        Domicilio = "Av. Piedrabuena 3200",
                        Localidad = "CABA",
                        Edad = 40,
                        ObraSocial = "OSDE"
                    },


                    new Paciente

                    {

                        Nombre = "Gabriel",
                        Apellido = "Fernandez",
                        FechaAsistencia = DateTime.Parse("24-5-2022 16:30:00.000+01:00"),
                        Domicilio = "Av. Eva Peron 5090",
                        Localidad = "CABA",
                        Edad = 47,
                        ObraSocial = "Unión Personal"
                    },


                    new Paciente

                    {

                        Nombre = "Pedro",
                        Apellido = "Paz",
                        FechaAsistencia = DateTime.Parse("25-5-2022 10:00:00.000+01:00"),
                        Domicilio = "Calle Falsa 123",
                        Localidad = "Buenos Aires",
                        Edad = 30,
                        ObraSocial = "Galeno"
                    },


                    new Paciente

                    {
                        Nombre = "Miguel",
                        Apellido = "Lopez",
                        FechaAsistencia = DateTime.Parse("28-5-2022 11:40:00.000+01:00"),
                        Domicilio = "Av. Rivadavia 3310",
                        Localidad = "CABA",
                        Edad = 34,
                        ObraSocial = "Medicus"
                    }

                );
                context.Diente.AddRange(
                    new Diente
                    {
                        IdPaciente = 1,
                        Diente1 = "",
                        Diente2 = "",
                        Diente3 = "",
                        Diente4 = "",
                        Diente5 = "",
                        Diente6 = "",
                        Diente7 = "",
                        Diente8 = "Caries",
                        Diente9 = "",
                        Diente10 = "",
                        Diente11 = "",
                        Diente12 = "Protesis Fija",
                        Diente13 = "",
                        Diente14 = "",
                        Diente15 = "",
                        Diente16 = "",
                        Diente17 = "",
                        Diente18 = "",
                        Diente19 = "",
                        Diente21 = "",
                        Diente22 = "",
                        Diente23 = "",
                        Diente24 = "",
                        Diente25 = "",
                        Diente26 = "",
                        Diente27 = "",
                        Diente28 = "",
                        Diente29 = "Protesis Removible",
                        Diente30 = "",
                        Diente31 = "",
                        Diente32 = "",
                    },

                    new Diente
                    {
                        IdPaciente = 2,
                        Diente1 = "",
                        Diente2 = "",
                        Diente3 = "",
                        Diente4 = "",
                        Diente5 = "",
                        Diente6 = "",
                        Diente7 = "",
                        Diente8 = "Extracción",
                        Diente9 = "",
                        Diente10 = "",
                        Diente11 = "",
                        Diente12 = "Protesis Fija",
                        Diente13 = "Protesis Fija",
                        Diente14 = "Protesis Fija",
                        Diente15 = "",
                        Diente16 = "",
                        Diente17 = "",
                        Diente18 = "",
                        Diente19 = "",
                        Diente21 = "",
                        Diente22 = "",
                        Diente23 = "",
                        Diente24 = "",
                        Diente25 = "",
                        Diente26 = "",
                        Diente27 = "Caries",
                        Diente28 = "Caries",
                        Diente29 = "",
                        Diente30 = "Caries",
                        Diente31 = "",
                        Diente32 = "",
                    }
                    );

                context.Turno.AddRange(
                    new Turno
                    {
                        Nombre = "Alfonso",
            
                        Apellido = "Cuaron",

                        CorreoElectronico = "riverplate123@gmail.com",

                        FechaTurno = DateTime.Parse("20-7-2022 09:30:00.000+01:00"),

                        Comentario = ""
                    },

                    new Turno
                    {
                        Nombre = "Roberto",

                        Apellido = "Gomez",

                        CorreoElectronico = "robertgomez@hotmail.com",

                        FechaTurno = DateTime.Parse("24-7-2022 17:00:00.000+01:00"),

                        Comentario = "Es con urgencia."
                    }, 

                    new Turno
                    {
                        Nombre = "Laura",

                        Apellido = "Gimenez",

                        CorreoElectronico = "laurigimenez@gmail.com",

                        FechaTurno = DateTime.Parse("1-8-2022 15:30:00.000+01:00"),

                        Comentario = ""
                    }

                    );

                context.SaveChanges();

            }

        }

    }

}
