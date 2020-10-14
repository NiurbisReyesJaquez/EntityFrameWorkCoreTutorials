using EntityFrameworkCoreTutorials.DAL;
using EntityFrameworkCoreTutorials.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFrameworkCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear
            /*
            using (var db = new Contexto())
            {
                var curso = new Curso()
                {
                    Nombre = "Cuarto"
                };
                db.Cursos.Add(curso);
                db.SaveChanges();

                var estudiante = new Estudiante()
                {
                    Nombre = "Niurbis",
                    Apellido = "Reyes",
                    FechaNacimiento = DateTime.Now,
                    CursoId = 1
                };

                db.Estudiantes.Add(estudiante);
                db.SaveChanges();
            }*/

            //Modificar
            /*using (var db = new Contexto())
            {
                var estudiante = db.Estudiantes.First<Estudiante>();
                estudiante.Nombre = "Niurbis";
                db.SaveChanges();
            }*/

            //Eliminar
            /*using (var db = new Contexto())
            {
                var std = db.Estudiantes.First<Estudiante>();
                db.Estudiantes.Remove(std);

                db.SaveChanges();
            }*/

            //Consultar
            var contexto = new Contexto();
            var estudiantesConElMismoNombre = contexto.Estudiantes.Where(s => s.Nombre == "Niurbis").ToList();

            foreach (var item in estudiantesConElMismoNombre)
            {
                Console.WriteLine("Nombre: " + item.Nombre + ". Apellido: " + item.Apellido);
            }
            Console.WriteLine("\n");
        }
    }
}
