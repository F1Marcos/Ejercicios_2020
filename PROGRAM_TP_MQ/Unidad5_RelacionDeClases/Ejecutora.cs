using System;
using System.Collections.Generic;
namespace Unidad5_RelacionDeClases
{
    class Ejecutora
    {
        static void Main(string[] args)
        {
            /*
            ##########################################################
            ## Autor: Martin Tejeria - IFTS11 - 2020                ##
            ##     ---    PROGRAMACION APLICADA ---                 ##
            ## New version: Marcos Quispe - IFTS 2020               ##
            ##                                                      ##
            ##########################################################
                   
            Referencias:
            http://ifts11.com/virtual/pluginfile.php/4327/mod_resource/content/1/Programaci%C3%B3n%20Aplicada%20Cuadernillo%20V9.docx
            https://www.youtube.com/watch?v=nRCZf5M0D-I
            http://alumnosdc.blogspot.com/2013/05/agregacion-composicion-y-dependencia.html
            */
            menu();
        }

        private static void menu()
        {
            List<Alumno> alumnos = new List<Alumno>();
            //Categoria cat = null;

            int opcion = -1;
            do
            {
                Console.Clear();
                do{
                Console.WriteLine(textoMenu());
                //opcion = int.Parse(Console.ReadLine());
                }while(int.TryParse(Console.ReadLine(), out opcion) is false);
                switch (opcion)
                {                    
                    case 1: // agregar alumno
                        Console.Clear();
                        // crear construtro Alumno();
                        alumnos.Add(new Alumno());
                        break;                    
                    case 2: // excluir alumno
                        Console.Clear();
                        menuItem2(alumnos);
                        break;                    
                    case 3: // mostrar datos del alumno
                        Console.Clear();
                        verDatosAlumnos(alumnos);
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;                    
                    case 4: // incribir a materias
                        Console.Clear();
                        menuItem4(alumnos);
                        break;                    
                    case 5: // des inscribir a materias
                        Console.Clear();
                        menuItem5(alumnos);
                        break;                    
                    case 6: // agregar materias
                        Console.Clear();
                        new Materia();
                        break;                    
                    case 7: // mostrar materias
                        Console.Clear();
                        Materia.mostrarMaterias();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 8: // agregar categorias
                        Console.Clear();
                        new Categoria();
                        break;
                    case 9: // mostrar categorias
                        Console.Clear();
                        Categoria.mostrarCategorias();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine(Materia.alumnosXMateria());
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 11: // asociar categoria Alumno
                        Console.Clear();
                        menuItem11(alumnos);
                        break;
                    case 12:
                        Console.Clear();
                        // Este metodo solo muesta al alumno que se inscribio en TODAS las clases
                        verDatosAlumnoFull(alumnos);
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();                        
                        break;
                    case 13:
                        string flag = "";
                        // pasar telfono SI o NO
                        Console.Clear();
                        alumnos.Add(new Alumno(flag));
                        break;
                    case 0:
                        Console.WriteLine("FIN DEL PROGRAMA");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
            } while (opcion != 0);
        }
        private static string textoMenu()
        {
            string texto = "***************************\n";
            texto += "Elija una opcion:\n";
            texto += "-----------------\n";
            texto += "1 - Para agregar alumnos\n";
            texto += "13 - Para agregar alumnos SIN telefono\n";            
            texto += "2 - Para excluir alumnos\n";
            texto += "3 - Para mostrar los datos de los alumnos\n";
            texto += "4 - Para inscribir alumno en materia \n";
            texto += "5 - Para desinscribir alumno de materia\n";
            texto += "6 - Para agregar materias\n";
            texto += "7 - Para mostrar materias\n";
            texto += "8 - Para agregar categorias\n";
            texto += "9 - Para mostrar categorias\n";
            texto += "10 - Para mostrar Alumnos inscriptos por materia\n";
            texto += "11 - Para asociar categoria Alumno\n";
            texto += "12 - Para mostrar los alumnos que tienen todas las materias\n";
            texto += "0 - Para salir del programa\n";
            texto += "***************************\n";
            return texto;
        }

        private static void verDatosAlumnos(List<Alumno> alumnos)
        {
           // facil
            Console.WriteLine("-------------------");
            Console.WriteLine("Alumnos disponibles:");
            Console.WriteLine("-------------------");
            foreach( Alumno aux in alumnos)
            {
                Console.WriteLine(aux.ToString());
            }
            Console.WriteLine();
        }

        private static void verDatosAlumnoFull(List<Alumno> alumnos)
        {
            foreach(Alumno objAlumno in alumnos)
            {
                if(Materia.cantidadMaterias() == objAlumno.verDatosAlumnoFull())
                    Console.WriteLine(objAlumno.ToString());
            }
        }
        private static void menuItem2(List<Alumno> alumnos)
        {
            //facil
            // ITEM: Seleccione 2 para excluir alumnos
            int opc;
            do{
            Console.WriteLine("Elija el ID de Alumno que quiere excluir o 999 para salir:");
            verDatosAlumnos(alumnos);
            Console.WriteLine();
            //}while(int.TryParse(Console.ReadLine(), out opc) is false); // OK
            }while((int.TryParse(Console.ReadLine(), out opc) is false) || !(alumnos.Exists(x => x.IdAlumno == opc)));
            alumnos.RemoveAll(x => x.IdAlumno == opc);
            Materia.BorrarAlumnoDeMateria(opc);  // DESAROLLAR.....
            //Materia.listaMateria[aux].desvinculaMateria();
            /*
            for (aux=0; aux < alumnos.Count; aux++ )
            {
                if (alumnos[aux].idAlumno == opc)
                {
                    break;
                }
            }
            alumnos.removeAt(aux);
            alumnos[aux].desvinculaMateria();
            */
        }

        private static void menuItem4(List<Alumno> alumnos)
        {
            // ITEM: Seleccione 4 para inscribir alumno en materia//
            //Console.WriteLine("se debe permitir Seleccionar un alumno para inscribirlo de una materia, 999 para salir");
            // utilizar los metodos provistos en las clases
            // verDatosAlumnos(alumnos); alumno.vincularAlumnoaMateria();
            int opc, aux;
            do{
            Console.WriteLine("Elija el ID de Alumno que quiere inscribir:");
            verDatosAlumnos(alumnos);
            Console.WriteLine();            
            //}while(int.TryParse(Console.ReadLine(), out opc) is false); // OK
            }while((int.TryParse(Console.ReadLine(), out opc) is false) || !(alumnos.Exists(x => x.IdAlumno == opc)));
            for ( aux =0; aux < alumnos.Count; aux++ )
            {
                if (alumnos[aux].IdAlumno == opc)
                {
                    break;
                }            
            }
            alumnos[aux].vincularAlumnoaMateria();
        }

        private static void menuItem5(List<Alumno> alumnos)
        {
            Console.WriteLine("se debe permitir des-Seleccionar un alumno para des-inscribirlo de una materia, 999 para salir");
            // ITEM: Seleccione 5 para desinscribir alumno de materia
            // utilizar los metodos provistos en las clases
            // verDatosAlumnos(alumnos); alumno.desvinculaMateria()
            int opc, aux;
            do{
            Console.WriteLine("Elija el ID de Alumno que quiere des-inscribir:");
            verDatosAlumnos(alumnos);
            Console.WriteLine();
            }while(int.TryParse(Console.ReadLine(), out opc) is false);
            for ( aux =0; aux < alumnos.Count; aux++ )
            {
                if (alumnos[aux].IdAlumno == opc)
                {
                    break;
                }            
            }
            alumnos[aux].desvinculaMateria();
        }

        private static void menuItem11(List<Alumno> alumnos)
        {
            Console.WriteLine("se debe permitir agregar una o mas categorias y asociarlas al alumno");
            //utilizar los metodos provistos en las clases
            // Categoria.mostrarCategorias()/verDatosAlumnos(alumnos)/Categoria.obtenerCategoria(opcionM2)
            // ITEM: Seleccione 11 asociar categoria Alumno
            int opc, aux, opcion;
            do{
            Console.WriteLine("Elija el ID de Alumno que quiere inscribir:");
            verDatosAlumnos(alumnos);
            Console.WriteLine();
            //}while(int.TryParse(Console.ReadLine(), out opc) is false);
            }while((int.TryParse(Console.ReadLine(), out opc) is false) || !(alumnos.Exists(x => x.IdAlumno == opc)));
            for ( aux =0; aux < alumnos.Count; aux++ )
            {
                if (alumnos[aux].IdAlumno == opc)
                {
                    break; // Aca se guarda el ID del alumno elegido dontro de aux //
                }            
            }
            do{
            Console.WriteLine("Seleccione la categoria a vincular en el alumno:");
            Categoria.mostrarCategorias();
            Console.WriteLine();
            }while(int.TryParse(Console.ReadLine(), out opcion) is false);
            // Categorias:
            alumnos[aux].IdCategoria = Categoria.obtenerCategoria(opcion);
        }
    }
}