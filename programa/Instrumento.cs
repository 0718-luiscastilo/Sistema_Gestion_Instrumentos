using System;
public class Instrumento{
    private int codigo;
    private string nombre;
    private string area_instalacion;
    private string fabricante;
    private string modelo;
    private int horas_uso;
    private string estado;
    private string fecha_calibracion;

    public int Codigo{
        get {
            return codigo;
        }
        set{
            if(value>=0){
                codigo = value;
            }
        }
    }
    public string Nombre{
        get {
            return nombre;
        }
        set{
            nombre = value;
        }
    }
    public string Area_Instalacion{
        get {
            return area_instalacion;
        }
        set{
            area_instalacion = value;
        }
    }
    public string Fabricante{
        get {
            return fabricante;
        }
        set{
            fabricante = value;
        }
    }
    public string Modelo{
        get {
            return modelo;
        }
        set{
            modelo = value;
        }
    }
    public int Horas_Uso{
        get {
            return horas_uso;
        }
        set{
            if(value >=0){
                horas_uso = value;
            }
        }
    }
    public string Estado{
        get {
            return estado;
        }
        set{
            estado = value;
        }
    }
    public string Fecha_calibracion{
        get {
            return fecha_calibracion;
        }
        set{
            fecha_calibracion = value;
        }
    }
    public Instrumento(int codigo, string nombre, string area_instalacion,string fabricante, string modelo,
    int horas_uso, string estado, string fecha_calibracion){
        this.codigo = codigo;
        this.nombre = nombre;
        this.area_instalación = area_instalacion;
        this.fabricante = fabricante;
        this.modelo = modelo;
        this.horas_uso = horas_uso;
        this.estado = estado;
        this.fecha_calibracion = fecha_calibracion;
    }
    public Instrumento(){
        codigo = 0;
        nombre = "";
        area_instalacion = "";
        fabricante = "";
        modelo = "";
        horas_uso = 0;
        estado = "Activo";
        fecha_calibracion = "";
    }
    virtual public void MostrarInformacion(){
        Console.WriteLine( "Codigo: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Area de Instalacion: " + Area_Instalacion);
        Console.WriteLine("Fabricante: " + Fabricante);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Horas de Uso: " + Horas_Uso);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Fecha de Calibracion: " + Fecha_calibracion);
    }
    public void ActualizarHorasUso(int actualizar_horas){
        if (actualizar_horas <= 0){
            Console.WriteLine( "Las Horas  debe ser mayor que 0.");
        }
        else if (actualizar_horas < horas_uso){
            Console.WriteLine("ERROR: no puede ser menor al horas uso actual.");
        }else{
            horas_uso += actualizar_horas;
            Console.WriteLine( "Las horas Uso se actualizaron correctamente.");
        }
    }
    public void cambiarEstado(string nuevoEstado){
        if (string.IsNullOrWhiteSpace(nuevoEstado)){
            Console.WriteLine("ERROR: el estado no puede estar vacío.");
        }else if (nuevoEstado.Equals("Activo", StringComparison.OrdinalIgnoreCase)){
            estado = "Activo";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase)){
            estado = "Inactiivo";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase)){
            estado = "En mantenimiento";
            Console.WriteLine("Estado actualizado correctamente.");
        }else if (nuevoEstado.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase)){
            estado = "Fuera de servicio";
            Console.WriteLine("Estado actualizado correctamente.");
        }else{
            Console.WriteLine("Estados permitidos:");
            Console.WriteLine("- Activo");
            Console.WriteLine("- Inactivo");
            Console.WriteLine("- En mantenimiento");
            Console.WriteLine("- Fuera de servicio");
        }
    }
    public bool RequiereMantenimiento(){
        if(horas_uso >= 500){
            return true;
        }else{
            return false;
        }
    }
    public void MostrarEstadoMantenimiento(){
        if(RequiereMantenimiento()){
            Console.WriteLine("El equipo necesita mantenimiento");
            cambiarEstado("En Mantemiento");
        }else{
            Console.WriteLine("El equipo esta en operacion");
        }
    }

}