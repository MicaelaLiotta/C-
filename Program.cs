namespace ParcialLaboratorio2;
class Program
{
    /* Almacenar la info de los alumnos en la siguiente estructura:
     Copie los nombres de los aprobados en una matriz Aprobados.

    Calcule el promedio del curso.

    Cree una función que calcule e imprima la nota más alta.

    Cree una función que calcule e imprima la nota más baja.

    Imprima la matriz Aprobados*/

    /*  Se aprueba con 60%

    el campo notaParcial tiene el % obtenido en el examen

    El curso tiene hasta 60 alumnos.*/

    struct Alumno
    {
        public string nombre;
        public int notaParcial_2;
    }

    static void ImprimirNotaAlta(Alumno[] alumnos, int numAlumnos)
    {
        if (numAlumnos == 0)
        {
            Console.WriteLine("No hay alumnos para evaluar.");
            return;
        }

        int notaMasAlta = alumnos[0].notaParcial_2;

        for (int i = 1; i < numAlumnos; i++)
        {
            if (alumnos[i].notaParcial_2 > notaMasAlta)
                notaMasAlta = alumnos[i].notaParcial_2;
        }
        Console.WriteLine(" La nota más alta es: {0}", notaMasAlta);
    }

    static void ImprimirNotaBaja(Alumno[] alumnos, int numAlumnos)
    {
        if (numAlumnos == 0)
        {
            Console.WriteLine("No hay alumnos para evaluar.");
            return;
        }

        int notaMasBaja = alumnos[0].notaParcial_2;
        for (int i = 1; i < numAlumnos; i++)
        {
            if (alumnos[i].notaParcial_2 < notaMasBaja)
                notaMasBaja = alumnos[i].notaParcial_2;
        }
        Console.WriteLine("La nota más baja es: {0} ", notaMasBaja);
    }

    static double Promedio(Alumno[] alumnos, int numAlumnos)  //es un arreglo de estructuras Alumno que contiene la información de los alumnos y sus notas parciales.
    {                                                             //El segundo parámetro, int numAlumnos, es un entero que indica la cantidad de alumnos en el arreglo alumnos
        int sumaNotas = 0;

        for (int i = 0; i < numAlumnos; i++)
        {
            sumaNotas += alumnos[i].notaParcial_2;
        }

        return (double)sumaNotas / numAlumnos;
    }


    static void Main()
    {
        int MaxAlumnos = 60;
        Alumno[] alumnos = new Alumno[MaxAlumnos];
        string[,] aprobados = new string[MaxAlumnos, 2];
        int numAlumnos = 0;




        for (int i = 0; i < MaxAlumnos; i++)
        {
            Console.WriteLine("Ingrese el nombre del alumno (o 'FIN' para terminar):");
            string nombre = Console.ReadLine();

            if (nombre.ToUpper() == "FIN")
            {
                break;
            }


            Console.WriteLine("Ingrese la nota del parcial:");
            int notaParcial_2 = Convert.ToInt32(Console.ReadLine());

            alumnos[numAlumnos].nombre = nombre;
            alumnos[numAlumnos].notaParcial_2 = notaParcial_2;


            if (notaParcial_2 >= 60)
            {
                aprobados[numAlumnos, 0] = nombre;
                aprobados[numAlumnos, 1] = notaParcial_2.ToString();
            }
            numAlumnos++;
        }



        Console.WriteLine("Matriz de Aprobados:");
        for (int i = 0; i < numAlumnos; i++)
        {
            if (!string.IsNullOrEmpty(aprobados[i, 0]))
            {
                Console.WriteLine("Nombre: {0}, Nota Parcial: {1}", aprobados[i, 0], aprobados[i, 1]);
            }
        }

        Console.WriteLine("El promedio es: " + Promedio(alumnos, numAlumnos));
        ImprimirNotaAlta(alumnos, numAlumnos);
        ImprimirNotaBaja(alumnos, numAlumnos);


    }


}






