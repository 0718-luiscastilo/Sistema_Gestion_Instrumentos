using System;
public class Program{
    public static void Main(string[] args){
        const int MAX_INSTRUMENTOS =100;
        int totalInstrumentos =0;
        Instrumento[] instrumentos  = new Instrumento[MAX_INSTRUMENTOS];
        int opcion;
        do{
            opcion = Funciones.MostrarMenu();
            switch(opcion){
                case 1:
                Console.WriteLine("Registrar sensor de temperatura.");
                break;
                case 2:
                Console.WriteLine("Registrar medidor de presión");
                break;
                case 3:
                Console.WriteLine("Mostrar todos los instrumentos");
                break;
                case 4:
                Console.WriteLine("Buscar instrumento por código");
                break;
                case 5:
                Console.WriteLine("Buscar instrumentos por área");
                break;
                case 6:
                Console.WriteLine("Actualizar horas de uso");
                break;
                case 7:
                Console.WriteLine("Cambiar estado");
                break;
                case 8:
                Console.WriteLine("Calibrar instrumento");
                break;
                case 9:
                Console.WriteLine("Mostrar instrumentos que requieren mantenimiento");
                break;
                case 10:
                Console.WriteLine("Mostrar resumen del sistema");
                break;
                case 11:
                Console.WriteLine("Gracias por utilizar el Sistema.");
                break;
                default:
                Console.WriteLine("Opción no reconocida.");
                break;
            }
        }while(opcion != 11);
        
    }
}
