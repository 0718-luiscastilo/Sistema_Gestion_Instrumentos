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
                Funciones.RegistrarSensorTemperatura(instrumentos, ref totalInstrumentos, MAX_INSTRUMENTOS);
                break;
                case 2:
                Funciones.RegistrarMedidorPresion(instrumentos, ref totalInstrumentos, MAX_INSTRUMENTOS);
                break;
                case 3:
                Funciones.MostrarTodosLosInstrumentos(instrumentos, totalInstrumentos);
                break;
                case 4:
                Funciones.BuscarInstrumentoPorCodigo(instrumentos, totalInstrumentos);
                break;
                case 5:
                Funciones.BuscarInstrumentosPorArea(instrumentos, totalInstrumentos);
                break;
                case 6:
                Funciones.ActualizarHorasDeUso(instrumentos, totalInstrumentos);
                break;
                case 7:
                Funciones.CambiarEstado(instrumentos, totalInstrumentos);
                break;
                case 8:
                Funciones.CalibrarInstrumento(instrumentos, totalInstrumentos);
                break;
                case 9:
                Funciones.MostrarEstadisticas(instrumentos, totalInstrumentos);
                break;
                case 10:
                Console.WriteLine("Gracias por utilizar el Sistema.");
                break;
                default:
                Console.WriteLine("Opción no reconocida.");
                break;
            }
        }while(opcion != 10);
        
    }
}
