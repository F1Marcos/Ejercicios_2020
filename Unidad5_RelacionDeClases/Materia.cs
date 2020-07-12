using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad5_RelacionDeClases
{
    class Materia
    {
        public static int idGenerador;
        private int idMateria;
        private string descripcion;
        private List<Alumno> listaAlumno = new List<Alumno>();
        private static List<Materia> listaMateria = new List<Materia>();
        public string Descripcion {get => descripcion; set=> descripcion = value; }
        public int IdMateria {get => idMateria; set => idMateria = value; }
        public Materia()
        {
            this.idMateria = idGenerador++;
           
           Console.WriteLine("Ingrese la descripción de la Materia");
            this.descripcion = Console.ReadLine();
            listaMateria.Add(this);

        }
        /*
        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        */
        public void vincularAlumno(Alumno alum)
        {
            listaAlumno.Add(alum);
        }
        public void desVincularAlumno(Alumno alum)
        {
            listaAlumno.Remove(alum);
        }

        public static void BorrarAlumnoDeMateria(int idAlumno)
        {
            foreach(Materia objMateria in listaMateria)
            {
                objMateria.listaAlumno.RemoveAll(x => x.IdAlumno == idAlumno );
            }
            //listaAlumno.RemoveAll(x => x.idAlumno == idAlumno );
        }
        public static int cantidadMaterias()
        {
            return listaMateria.Count;
        }

        public static Materia obtenerMateria(int idMateria)
        {
            return listaMateria.Find(x => x.idMateria == idMateria);
        }
        public static void mostrarMaterias()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Materias disponibles:");
            Console.WriteLine("--------------------");
            foreach (Materia objMateria in listaMateria)
            {
                Console.WriteLine($"|ID:{objMateria.idMateria}     |Descripcion:{objMateria.descripcion} |");
            }
            Console.WriteLine();
        }
/*
        // MA-START
        public static string MostrarAlumnosMateria(Materia mat) 
        { 
          string alumnosdeMateria = ""; 
          foreach(Alumno a in mat.listaAlumno) 
          { 
              alumnosdeMateria += a.Nombre;
           } 
           return alumnosdeMateria; 
        }
        public static String alumnosXMateria() 
        { 
                String alumnos = ""; 
                foreach (Materia m in listaMateria) 
                { 
                    alumnos += m.getDescripcion(); 
                    alumnos += MostrarAlumnosMateria(m); 
                    } 
                    return alumnos; 
        }
        // MA-END  
*/
        public static string alumnosXMateria() 
        { 
            String alumnos = "";
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Alumnos inscriptos en cada materia:");
            Console.WriteLine("----------------------------------");
            foreach (Materia m in listaMateria) 
            {
            alumnos += "|Materia " + m.Descripcion + " - Lista de alumnos:";
                foreach(Alumno a in m.listaAlumno) 
                { 
                    alumnos += " " + a.Nombre + ";";
                }
            alumnos += " |\n";
            }
            Console.WriteLine();
            return alumnos; 
        }
    }
}
