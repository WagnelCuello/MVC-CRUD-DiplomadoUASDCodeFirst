using MVC_CRUD_Becasoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_Becasoft.DAL
{
    public class CargaDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<BecasoftContext>
    {
        protected override void Seed(BecasoftContext context)
        {
            var Cursos = new List<Curso>
            {
                new Curso { CursoID = 1, Descripcion = "Programacion I", },
                new Curso { CursoID = 2, Descripcion = "Programacion II", },
                new Curso { CursoID = 3, Descripcion = "Programacion III", },
                new Curso { CursoID = 4, Descripcion = "Programacion Web", },
                new Curso { CursoID = 5, Descripcion = "Analisis y Diseño de Sistemas", },
                new Curso { CursoID = 6, Descripcion = "Matematica Financiera", },
                new Curso { CursoID = 7, Descripcion = "Base de Datos", }
            };

            var Estudiantes = new List<Estudiante>
            {
                new Estudiante{ EstudianteID = 1, Nombres = "Genry", Apellidos = "Fernandez", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 2, Nombres = "Miguel", Apellidos = "Perez", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 3, Nombres = "Juan", Apellidos = "Matos", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 4, Nombres = "Ezequiel", Apellidos = "Hernandez", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 5, Nombres = "Elsa", Apellidos = "Mendieta", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 6, Nombres = "Elvin", Apellidos = "Volquez", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 7, Nombres = "Susana", Apellidos = "Pelaez", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 8, Nombres = "Carlos", Apellidos = "Mendez", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 9, Nombres = "Shon", Apellidos = "Gohan", Fecha_Inscripcion = DateTime.Now, },
                new Estudiante{ EstudianteID = 10, Nombres = "Tao", Apellidos = "Pai Pai", Fecha_Inscripcion = DateTime.Now, }
            };

            var Inscripciones = new List<Inscripcion>
            {
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 1, CursoID = 1, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 1, CursoID = 2, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 1, CursoID = 3, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 1, CursoID = 4, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 1, CursoID = 5, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 1, CursoID = 6, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 1, CursoID = 7, },

                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 2, CursoID = 1, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 2, CursoID = 2, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 2, CursoID = 3, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 2, CursoID = 4, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 2, CursoID = 5, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 2, CursoID = 6, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 1, Semestre = 2, CursoID = 7, },

                new Inscripcion { InscripcionID = 1, EstudianteID = 2, Semestre = 1, CursoID = 1, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 2, Semestre = 1, CursoID = 2, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 2, Semestre = 1, CursoID = 3, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 2, Semestre = 1, CursoID = 4, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 2, Semestre = 1, CursoID = 5, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 2, Semestre = 1, CursoID = 6, },
                new Inscripcion { InscripcionID = 1, EstudianteID = 2, Semestre = 1, CursoID = 7, },

                new Inscripcion { InscripcionID = 2, EstudianteID = 2, Semestre = 1, CursoID = 1, },
                new Inscripcion { InscripcionID = 2, EstudianteID = 2, Semestre = 1, CursoID = 2, },
                new Inscripcion { InscripcionID = 2, EstudianteID = 2, Semestre = 1, CursoID = 3, },
                new Inscripcion { InscripcionID = 2, EstudianteID = 2, Semestre = 1, CursoID = 4, },
                new Inscripcion { InscripcionID = 2, EstudianteID = 2, Semestre = 1, CursoID = 5, },
                new Inscripcion { InscripcionID = 2, EstudianteID = 2, Semestre = 1, CursoID = 6, },
                new Inscripcion { InscripcionID = 2, EstudianteID = 2, Semestre = 1, CursoID = 7, }
            };

            Cursos.ForEach(s => context.Curso.Add(s));
            context.SaveChanges();

            Estudiantes.ForEach(s => context.Estudiante.Add(s));
            context.SaveChanges();

            Inscripciones.ForEach(s => context.Inscripcion.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
