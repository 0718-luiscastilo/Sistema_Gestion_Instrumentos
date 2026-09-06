using System;
public class Funciones{
    public static int MostrarMenu(){
    int opcion;
    do{
        Console.WriteLine("========================================");
        Console.WriteLine("===== SISTEMA DE GESTIÓN DE INSTRUMENTOS =====");
        Console.ReadKey();
        Console.WriteLine("1. Registrar sensor de temperatura.");
        Console.WriteLine("2. Registrar medidor de presión.");
        Console.WriteLine("3. Mostrar todos los instrumentos.");
        Console.WriteLine("4. Buscar instrumento por código");
        Console.WriteLine("5. Buscar instrumentos por área");
        Console.WriteLine("6. Actualizar horas de uso.");
        Console.WriteLine("7. Cambiar estado");
        Console.WriteLine("8. Calibrar instrumento.");
        Console.WriteLine("9. Mostrar instrumentos que requieren mantenimiento");
        Console.WriteLine("10. Mostrar resumen del sistema.");
        Console.WriteLine("11.- Salir ");
        Console.WriteLine("Seleccione una opcion: ");
        if (int.TryParse(Console.ReadLine(), out op) && opcion >= 1 && opcion <= 11){
            return opcion;
        }
        Console.WriteLine("Error. Debe seleccionar una opcion valida. ");
        Console.WriteLine();
    }while(true);
}

}