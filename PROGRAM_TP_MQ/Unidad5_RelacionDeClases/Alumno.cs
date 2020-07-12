using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unidad5_RelacionDeClases
{
    class Alumno
    {
        private static int idGenerador;
        private int idAlumno;
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimeinto ;
        private Categoria idCategoria;  // agregacion: la categoria de un alumno no depende de este, su existencia es independiente a este.
        private Domicilio idDomicilio;  // composicion: El domicilio del alumno tiene sentido y existe siempre que exista el alumno, es un objeto dependiente de éste
        private Materia idMateria;  // Asociacion: con Materias porque un alumno puede tener n Materias y una Materia puede estar en x Alumnos
        public int IdAlumno {get => idAlumno; set => idAlumno = value;}
        public string Nombre {get => nombre; }
        public string Apellido {get => apellido; }
        public DateTime FechaDeNacimeinto {get => fechaDeNacimeinto; set=> fechaDeNacimeinto = value; }
        public Domicilio IdDomicilio { set => idDomicilio = value; }
        public Categoria IdCategoria { set => idCategoria = value; }
        private List<Materia> ListaMateriasAlumno = new List<Materia>();
        private List<Telefono> ListaTelefono = new List<Telefono>();

        public Alumno()
        {         
            int opc; 
            this.idAlumno = idGenerador++;
            Console.WriteLine("Ingrese el nombre del alumno");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del alumno");
            this.apellido = Console.ReadLine();

            do{
            Console.WriteLine("Ingrese fecha de nacimiento con el siguiente formato: DD/MM/YYYY");
            //dt = DateTime.ParseExact(Console.ReadLine(), "01/12/2020", System.Globalization.CultureInfo.InvariantCulture);
            }while(!(DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out this.fechaDeNacimeinto)));
            Console.WriteLine($"PRUEVA FORMATO_FECHA -> {this.fechaDeNacimeinto.ToString("dd/MM/yyyy")}");

            this.idDomicilio = new Domicilio();
            do{
                ListaTelefono.Add(new Telefono());
                Console.WriteLine("Ingrese 1 para agregar otro telefono o 999 para salir:");
            //}while((int.TryParse(Console.ReadLine(), out opc) is false) || opc!= 999 ); // OK
            }while((int.TryParse(Console.ReadLine(), out opc) is false) || opc != 999 );
        }



        public Alumno(string flag)
        {         
            this.idAlumno = idGenerador++;
            Console.WriteLine("Ingrese el nombre del alumno");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del alumno");
            this.apellido = Console.ReadLine();
            do{
            Console.WriteLine("Ingrese fecha de nacimiento con el siguiente formato: DD/MM/YYYY");
            //dt = DateTime.ParseExact(Console.ReadLine(), "01/12/2020", System.Globalization.CultureInfo.InvariantCulture);
            }while(!(DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out this.fechaDeNacimeinto)));
            Console.WriteLine($"PRUEVA FORMATO_FECHA -> {this.fechaDeNacimeinto.ToString("dd/MM/yyyy")}");
            this.idDomicilio = new Domicilio();
        }




        public int verDatosAlumnoFull()
        {
            int aux = this.ListaMateriasAlumno.Count;            
            return aux;
        }
        /*
        public String getNombre()
        {
            return this.nombre;
        }
        public void setDomicilio(Domicilio idDomicilio)
        {
            this.idDomicilio = idDomicilio;
        }

        public void setCategoria(Categoria idCategoria)
        {
            this.idCategoria = idCategoria;
        }
        */
        public void vincularAlumnoaMateria()
        {
            int opcion;
            do{
            Console.WriteLine("Seleccione el ID de materia a vincular al alumno o 999 para salir");
            Materia.mostrarMaterias();
            }while(int.TryParse(Console.ReadLine(), out opcion) is false); // OK
            while (opcion != 999 && opcion >= 0 && opcion <= Materia.cantidadMaterias())
            {
                idMateria = Materia.obtenerMateria(opcion);
                ListaMateriasAlumno.Add(idMateria);
                idMateria.vincularAlumno(this);
                Console.WriteLine("Seleccione la materia a vincular al alumno 999 para salir");
                Materia.mostrarMaterias();
                opcion = int.Parse(Console.ReadLine());
            }
        }
        public void desvinculaMateria()
        {
            Materia idMateria;
            int opcion;
            do{
            Console.WriteLine("Seleccione el ID materia a DES-Vincular del alumno o 999 para salir");
            Console.WriteLine(this.materiasCursadas());
            }while(int.TryParse(Console.ReadLine(), out opcion) is false);
            while (opcion != 999 && opcion >= 0 && opcion <= ListaMateriasAlumno.Count)
            {
                idMateria = Materia.obtenerMateria(opcion);
                ListaMateriasAlumno.Remove(idMateria);
                idMateria.desVincularAlumno(this);
                do{
                Console.WriteLine("Seleccione el ID materia a DES-Vincular del alumno o 999 para salir");
                Console.WriteLine(this.materiasCursadas());
                }while(int.TryParse(Console.ReadLine(), out opcion) is false);
            }
        }
        public void materiasCursadasAlumno()
        {
            this.materiasCursadas();
        }

        private string materiasCursadas()  // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        {
            string materias = "";
            foreach (Materia objMateria in ListaMateriasAlumno)
            {
                materias += "ID-Materia:" + objMateria.IdMateria + "-" + objMateria.Descripcion;
            }
            return materias;
        }
        //START TEST
        public string numerosTelefonoAlumno()
        {
            string numTelefonos= "";
            foreach(Telefono objTelefono in ListaTelefono)
            {
                //numTelefonos += objTelefono.Caracteristica.ToString() + "-" + objTelefono.NumeroLocal.ToString() + "; ";
                numTelefonos += objTelefono.ToString() + "; ";
            }
            return numTelefonos;
        }
        //END TEST
        public void domicilio()
        {
           Console.WriteLine("El domicilio del alumno es: " + idDomicilio.ToString());
        }

        public override string ToString()
        {
            return ("|ID:" +this.idAlumno + "\t|Alumno:" + this.nombre + " " + this.apellido + "\t|" + this.idDomicilio.ToString() + "\t|" + this.materiasCursadas() + "\t|Categoria:" + this.idCategoria + "\t|Telefonos:" + this.numerosTelefonoAlumno() + "|");
        }

    }
}