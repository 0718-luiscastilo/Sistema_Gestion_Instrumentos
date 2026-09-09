using System;
public class MedidorPresion: Instrumento{
    private int presion_minima;
    private int presion_maxima;
    private string unidad_presion;

    public int Presion_minima{
        get {
            return presion_minima;
        }
        set{
            if(value>=0){
                presion_minima = value;
            }
        }
    }
    public int Presion_maxima{
        get {
            return presion_maxima;
        }
        set{
            if(value>=0){
                presion_maxima = value;
            }
        }
    }
    public string Unidad_presion{
        get {
            return unidad_presion;
        }
        set{
            unidad_presion = value;
        }
    }
    public MedidorPresion(int codigo, string nombre, string area_instalacion,string fabricante, string modelo,
    int horas_uso, string estado, string fecha_calibracion,
    int presion_minima, int presion_maxima, string unidad_presion) : base(codigo, nombre, area_instalacion,
    fabricante, modelo, horas_uso, estado, fecha_calibracion){
        this.presion_minima = presion_minima;
        this.presion_maxima = presion_maxima;
        this.unidad_presion = unidad_presion;
    }
    public void MostrarRangoPresion(){
        Console.WriteLine( "Presion Maxima: " + Presion_maxima);
        Console.WriteLine("Presion Minima: " + Presion_minima);
        Console.WriteLine("Unidad : " + Unidad_presion);
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
        Console.WriteLine( "Presion Maxima: " + Presion_maxima);
        Console.WriteLine("Presion Minima: " + Presion_minima);
        Console.WriteLine("Unidad : " + Unidad_presion); 
    }
    public void Calibrar(){
        if(Horas_Uso >= 15){
            Console.WriteLine("El Instrumentos neceita calibracion.");
        }else{
            Console.WriteLine("El Instrumentos no neceita calibracion.");
        }
    }
}