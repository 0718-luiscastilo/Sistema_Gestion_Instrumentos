using System;
public class SensorTemperatura: Instrumento{
    private int temperatura_minima;
    private int temperatura_maxima;
    private string unidad_temperatura;

    public int Temperatura_minima{
        get {
            return temperatura_minima;
        }
        set{
            if(value>=0){
                temperatura_minima = value;
            }
        }
    }
    public int Temperatura_maxima{
        get {
            return temperatura_maxima;
        }
        set{
            temperatura_maxima = value;
        }
    }
    public string Unidad_temperatura{
        get {
            return unidad_temperatura;
        }
        set{
            unidad_temperatura = value;
        }
    }
    public SensorTemperatura(int codigo, string nombre, string area_instalacion,string fabricante, string modelo,
    int horas_uso, string estado, string fecha_calibracion,
    int temperatura_minima, int temperatura_maxima, string unidad_temperatura) : base(codigo, nombre, area_instalacion,
    fabricante, modelo, horas_uso, estado, fecha_calibracion){
        this.temperatura_minima = temperatura_minima;
        this.temperatura_maxima = temperatura_maxima;
        this.unidad_temperatura = unidad_temperatura;

   }
   public void MostrarRangoTemperatura(){
        Console.WriteLine( "Temperatura Maxima: " + Temperatura_maxima);
        Console.WriteLine("Temperatura Minima: " + temperatura_minima);
        Console.WriteLine("Unidad : " + Unidad_temperatura);
    }
    public override void MostrarInformacion(){
        Console.WriteLine( "Codigo: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Area de Instalacion: " + Area_Instalacion);
        Console.WriteLine("Fabricante: " + Fabricante);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Horas de Uso: " + Horas_Uso);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Fecha de Calibracion: " + Fecha_calibracion);
        Console.WriteLine( "Temperatura Maxima: " + Temperatura_maxima);
        Console.WriteLine("Temperatura Minima: " + temperatura_minima);
        Console.WriteLine("Unidad : " + Unidad_temperatura);
    }
    public void Calibrar(){
        if(Horas_Uso >= 15){
            Console.WriteLine("El Instrumentos neceita calibracion.");
        }else{
            Console.WriteLine("El Instrumentos no neceita calibracion.");
        }
    }
}