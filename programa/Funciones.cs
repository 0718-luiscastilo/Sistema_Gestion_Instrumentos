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
            Console.WriteLine("9. Mostrar resumen del sistema.");
            Console.WriteLine("10.- Salir ");
            Console.WriteLine("Seleccione una opcion: ");
            if (int.TryParse(Console.ReadLine(), out op) && opcion >= 1 && opcion <= 10){
                return opcion;
            }
            Console.WriteLine("Error. Debe seleccionar una opcion valida. ");
            Console.WriteLine();
        }while(true);
    }
    public static void RegistrarSensorTemperatura(Instrumento[] instrumentos, ref int totalInstrumentos, int MAX_INSTRUMENTOS){
        if(totalInstrumentos >= MAX_INSTRUMENTOS){
            Console.WriteLine("Ya no hay espacio para más instrumentos.");
            return;
        }
        Console.WriteLine(" Ingrese el codigo: ");
        int codigo;
        while (!int.TryParse(Console.ReadLine(), out codigo) || codigo <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Nombre: ");
        string nombre = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nombre)){
            Console.Write("Error. El nombre no puede estar vacío. Intente nuevamente: ");
            nombre = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese Area de Instalacion: ");
        string areaInstalacion = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(areaInstalacion)){
            Console.Write("Error. El Area de Instalacion no puede estar vacío. Intente nuevamente: ");
            areaInstalacion = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese el Fabricante: ");
        string fabricante = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(fabricante)){
            Console.Write("Error. El Fabricante no puede estar vacío. Intente nuevamente: ");
            fabricante = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese modelo: ");
        string modelo = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(modelo)){
            Console.Write("Error. El modelo no puede estar vacío. Intente nuevamente: ");
            modelo = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese las horas de Uso: ");
        int horasUso;
        while (!int.TryParse(Console.ReadLine(), out horasUso) || horasUso < 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Estado: ");
        string estado = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(estado)){
            Console.Write("Error. El estado no puede estar vacío. Intente nuevamente: ");
            estado = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese la Fecha de Calibracion: ");
        string fechaCalibracion = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(fechaCalibracion)){
            Console.Write("Error. La fecha de Calibracion no puede estar vacío. Intente nuevamente: ");
            fechaCalibracion = Console.ReadLine();
        }
        Console.WriteLine(" Ingrese la Temperatura Minina: ");
        int tempMinima;
        while (!int.TryParse(Console.ReadLine(), out tempMinima)){
            Console.Write("Error. Ingrese una temperatura numérica válida: ");
        }
        
        Console.WriteLine(" Ingrese la Tempreratura Maxima: ");
        int tempMaxima;
        while (!int.TryParse(Console.ReadLine(), out tempMaxima) || tempMaxima <= tempMinima){
            Console.Write("Error. La temperatura máxima debe ser mayor que la mínima: ");
        }
        
        Console.WriteLine(" Ingrese la Unidad de Temperatura: ");
        string unidadTemp = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(unidadTemp)){
            Console.Write("Error. La fecha de Calibracion no puede estar vacío. Intente nuevamente: ");
            unidadTemp = Console.ReadLine();
        }

        Instrumento i = new SensorTemperatura(codigo,nombre,areaInstalacion,fabricante,modelo,horasUso,
        estado,fechaCalibracion,tempMaxima,tempMinima,unidadTemp);
        instrumentos[totalInstrumentos] = i;
        totalInstrumentos++;
        Console.WriteLine("Sensor de temperatura registrado correctamente.");
    }
    public static void RegistrarMedidorPresion(Instrumento[] instrumentos, ref int totalInstrumentos, int MAX_INSTRUMENTOS){
        if(totalInstrumentos >= MAX_INSTRUMENTOS){
            Console.WriteLine("Ya no hay espacio para más instrumentos.");
            return;
        }
        Console.WriteLine(" Ingrese el codigo: ");
        int codigo;
        while (!int.TryParse(Console.ReadLine(), out codigo) || codigo <= 0){
            Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
        }
        Console.WriteLine(" Ingrese el Nombre: ");
        string nombre = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(nombre)){
            Console.Write("Error. El nombre no puede estar vacío. Intente nuevamente: ");
            string nombre = Console.ReadLine() ?? "";
        }
        nombre = nombre.Trim();
        Console.WriteLine(" Ingrese Area de Instalacion: ");
        string areaInstalacion = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(areaInstalacion)){
            Console.Write("Error. El Area de Instalacion no puede estar vacío. Intente nuevamente: ");
            string areaInstalacion = Console.ReadLine() ?? "";
        }
        areaInstalacion = areaInstalacion.Trim();
        Console.WriteLine(" Ingrese el Fabricante: ");
        string fabricante = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(fabricante)){
            Console.Write("Error. El Fabricante no puede estar vacío. Intente nuevamente: ");
            string fabricante = Console.ReadLine() ?? "";
        }
        fabricante = fabricante.Trim();
        Console.WriteLine(" Ingrese modelo: ");
        string modelo = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(modelo)){
            Console.Write("Error. El modelo no puede estar vacío. Intente nuevamente: ");
            string modelo = Console.ReadLine() ?? "";
        }
        modelo = modelo.Trim();
        Console.WriteLine(" Ingrese las horas de Uso: ");
        int horasUso;
        while (!int.TryParse(Console.ReadLine(), out horasUso) || horasUso < 0){
            Console.Write("Error. Las horas de uso no pueden ser negativas: ");
        }
        Console.WriteLine(" Ingrese el Estado: ");
        string estado = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(estado)){
            Console.Write("Error. El estado no puede estar vacío. Intente nuevamente: ");
            string estado = Console.ReadLine() ?? "";
        }
        estado = estado.Trim();
        Console.WriteLine(" Ingrese la Fecha de Calibracion: ");
        string fechaCalibracion = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(fechaCalibracion)){
            Console.Write("Error. La fecha de Calibracion no puede estar vacío. Intente nuevamente: ");
            string fechaCalibracion = Console.ReadLine() ?? "";
        }
        fechaCalibracion = fechaCalibracion.Trim();

        Console.WriteLine(" Ingrese la Presion Minina: ");
        int presionMinima;
        while (!int.TryParse(Console.ReadLine(), out presionMinima)){
            Console.Write("Error. Ingrese una presion numérica válida: ");
        }
        
        Console.WriteLine(" Ingrese la  Presion Maxima: ");
        int presionMaxima;
        while (!int.TryParse(Console.ReadLine(), out presionMaxima) || presionMaxima <= presionMinima){
            Console.Write("Error. La presion máxima debe ser mayor que la mínima: ");
        }
        
        Console.WriteLine(" Ingrese la Unidad de Presion: ");
        string unidadPresion = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(unidadPresion)){
            Console.Write("Error. La unidad de presion no puede estar vacío. Intente nuevamente: ");
            unidadPresion = Console.ReadLine();
        }
        unidadPresion = unidadPresion.Trim();

        Instrumento p = new MedidorPresion(codigo,nombre,areaInstalacion,fabricante,modelo,horasUso,
        estado,fechaCalibracion,presionMinima,presionMaxima,unidadPresion);
        instrumentos[totalInstrumentos] = p;
        totalInstrumentos++;
        Console.WriteLine("Medidor de Presion registrado correctamente.");
    }
    public static void MostrarTodosLosInstrumentos(Instrumento[] instrumentos, int totalInstrumentos){
        if(totalInstrumentos == 0){
            Console.WriteLine("No hay instrumentos registrados.");
            return;
        }
        Console.WriteLine("===== TODOS LOS INSTRUMENTOS =====");
        for(int i=0;i<totalInstrumentos;i++){
            Console.WriteLine($"Instrumento #{i + 1}");
            instrumentos[i].MostrarInformacion();
            Console.WriteLine("==============================");
        }
    }
    public static void BuscarInstrumentoPorCodigo(Instrumento[] instrumentos, int totalInstrumentos){
        bool encontrado = false;
        if(totalInstrumentos == 0){
            Console.WriteLine("No hay instrumentos registrados.");
            return;
        }
        int buscarCodigo;
        Console.WriteLine("===== BUSCAR INSTRUMENTO =====");
        Console.WriteLine("Ingrese el codigo: ");
        while (!int.TryParse(Console.ReadLine(), out buscarCodigo) || buscarCodigo <= 0){
            Console.Write("Error. Ingrese un código numérico mayor que 0: ");
        }
        
        for(int i=0;i<totalInstrumentos;i++){
            if(instrumentos[i] != null && instrumentos[i].Codigo == buscarCodigo){
                encontrado = true;
                instrumentos[i].MostrarInformacion();
                Console.WriteLine("==============================");
                break;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontró un instrumento con ese código.");
        }
    }
    public static void BuscarInstrumentosPorArea(Instrumento[] instrumentos, int totalInstrumentos){
        bool encontrado = false;
        if(totalInstrumentos == 0){
            Console.WriteLine("No hay instrumentos registrados.");
            return;
        }
        Console.WriteLine("===== BUSCAR INSTRUMENTO POR AREA =====");
        Console.WriteLine("Ingrese la Area de Instalacion: ");
        string area = Console.ReadLine() ?? "";
        while (string.IsNullOrWhiteSpace(area)){
            Console.Write("Error. El area de Instalacion no puede estar vacía. Intente nuevamente: ");
            string area = Console.ReadLine() ?? "";
        }
        for(int i=0;i<totalInstrumentos;i++){
            if (instrumentos[i] != null && instrumentos[i].Area_Instalacion.Equals(areaBuscada, StringComparison.OrdinalIgnoreCase)){
                encontrado = true;
                instrumentos[i].MostrarInformacion();
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontraron instrumentos en esa área.");
        }
    }
    public static void ActualizarHorasDeUso(Instrumento[] instrumentos, int totalInstrumentos){
        bool encontrado = false;
        if(totalInstrumentos == 0){
            Console.WriteLine("No hay instrumentos registrados.");
            return;
        }
        Console.WriteLine("===== ACTUALIZAR HORAS DE USO =====");
        Console.WriteLine("Ingrese el codigo: ");
        int buscarCodigo;
        while (!int.TryParse(Console.ReadLine(), out buscarCodigo) || buscarCodigo <= 0){
            Console.Write("Error. Ingrese un código numérico mayor que 0: ");
        }
        for(int i=0;i<totalInstrumentos;i++){
            if(instrumentos[i] != null && instrumentos[i].Codigo == buscarCodigo){
                encontrado = true;
                Console.WriteLine("Ingrese las horas adicionales de uso: ");
                double horasAdicionales;
                while (!double.TryParse(Console.ReadLine(), out horasAdicionales) || horasAdicionales <= 0){
                Console.Write("Error. Ingrese un valor numérico mayor que 0: ");
                }
                instrumentos[i].ActualizarHorasUso(horasAdicionales);
                Console.WriteLine("\nValor actualizado correctamente.\n");
                Console.WriteLine("Información actualizada:");
                instrumentos[i].MostrarInformacion();
                break;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontró ningún instrumento con ese código.");
        }
    }
    public static void CambiarEstado(Instrumento[] instrumentos,int totalInstrumentos){
        bool encontrado = false;
        if(totalInstrumentos == 0){
            Console.WriteLine("No hay instrumentos registrados.");
            return;
        }
        Console.WriteLine("===== CAMBIAR ESTADO DEL INSTRUMENTO =====");
        Console.Write("Ingrese el código: ");
        int buscarCodigo;
        while (!int.TryParse(Console.ReadLine(), out buscarCodigo) || buscarCodigo <= 0){
            Console.Write("Error. Ingrese un código numérico mayor que 0: ");
        }
        for(int i=0;i<totalInstrumentos;i++){
            if(instrumentos[i] != null && instrumentos[i].Codigo == buscarCodigo){
                encontrado = true;
                Console.WriteLine("\n Instrumento encontrado:");
                instrumentos[i].MostrarInformacion();
                nuevoEstado = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(nuevoEstado) || (nuevoEstado != "Activo" && nuevoEstado != "Inactivo" && 
                nuevoEstado != "En mantenimiento" && nuevoEstado != "Fuera de Servicio")){
                    Console.Write("Estado inválido. Ingrese Activo, Inactivo, En mantenimiento, Fuera de servicio:");
                    nuevoEstado = Console.ReadLine()?.Trim() ?? "";
                    }
                string estadoAnterior = instrumentos[i].Estado;
                instrumentos[i].CambiarEstado(nuevoEstado);
                Console.WriteLine("\nEstado actualizado correctamente.\n");
                Console.WriteLine("Información actualizada:");
                instrumentos[i].MostrarInformacion();
                break;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontró ningún instrumento con ese código.");
        }
    }
    public static void CalibrarInstrumento(Instrumento[] instrumentos,int totalInstrumentos){
        bool encontrado = false;
        if(totalInstrumentos == 0){
            Console.WriteLine("No hay instrumentos registrados.");
            return;
        }
        Console.WriteLine("===== CALIBRAR INSTRUMENTO =====");
        Console.Write("Ingrese el código: ");
        int buscarCodigo;
        while (!int.TryParse(Console.ReadLine(), out buscarCodigo) || buscarCodigo <= 0){
            Console.Write("Error. Ingrese un código numérico mayor que 0: ");
        }
        for(int i=0;i<totalInstrumentos;i++){
            if(instrumentos[i] != null && instrumentos[i].Codigo == buscarCodigo){
                encontrado = true;
                Console.WriteLine("\n Instrumento encontrado:");
                instrumentos[i].MostrarInformacion();
                if (instrumentos[i] is ICalibrable instrumentoCalibrable){
                    Console.WriteLine("\n===== RESULTADO DE LA CALIBRACIÓN =====");
                    instrumentoCalibrable.Calibrar();
                    Console.WriteLine("\nInstrumento calibrado correctamente.");
                    Console.WriteLine("\nInformación de calibración:");
                    instrumentoCalibrable.MostrarInformacionCalibracion();
                    Console.WriteLine("\nInformación actualizada:");
                    instrumentos[i].MostrarInformacion();
                }else{Console.WriteLine("\nEste instrumento no admite calibración.");
                }
                break;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontró ningún instrumento con ese código.");
        }
    }
    public static void MostrarEstadisticas(Instrumento[] instrumentos,int totalInstrumentos){
        if(totalInstrumentos == 0){
            Console.WriteLine("No hay instrumentos registrados.");
            return;
        }
        Console.WriteLine("===== ESTADÍSTICAS DEL SISTEMA =====");
        int totalActivos = 0;
        int totalInactivos = 0;
        int totalMantenimiento = 0;
        int totalFueraServicio = 0;
        double totalHorasUso = 0;
        int totalSensores = 0;
        int totalMedidores = 0;
        int totalRequierenMantenimiento =0;
        int totalCalibrables = 0;

        for(int i =0; i<totalInstrumentos;i++){
            totalHorasUso += instrumentos[i].Horas_Uso;
            double promedio = totalHorasUso / totalInstrumentos;

            if(instrumentos[i].Estado =="Activo"){
                totalActivos++;
            }
            if(instrumentos[i].Estado =="Inactivo"){
                totalInactivos++;
            }
            if(instrumentos[i].Estado =="En mantenimiento"){
                totalMantenimiento++;
            }
            
            if (instrumentos[i].RequiereMantenimiento()){
                totalRequierenMantenimiento++;
            }
            if(instrumentos[i].Estado =="Fuera de Servicio"){
                totalFueraServicio++;
            }
             if (instrumentos[i] is ICalibrable){
                totalCalibrables++;
            }
            if(instrumentos[i] is SensorTemperatura){
                totalSensores++;
            }
            if(instrumentos[i] is MedidorPresion){
                totalMedidores++;
            } 
        }
         Console.WriteLine("\n===== RESUMEN GENERAL =====");

    Console.WriteLine($"Total de instrumentos: {totalInstrumentos}");
    Console.WriteLine($"Total de horas de uso: {totalHorasUso}");
    Console.WriteLine($"Promedio de horas de uso: {promedio:F2}");
    Console.WriteLine($"Instrumentos que requieren mantenimiento: {totalRequierenMantenimiento}");
    Console.WriteLine($"Instrumentos calibrables: {totalCalibrables}");
    Console.WriteLine($"Sensores de temperatura: {totalSensores}");
    Console.WriteLine($"Medidores de presión: {totalMedidores}");

    Console.WriteLine("\n===== ESTADÍSTICAS POR ESTADO =====");
    Console.WriteLine($"Activos: {totalActivos}");
    Console.WriteLine($"Inactivos: {totalInactivos}");
    Console.WriteLine($"En Mantenimiento: {totalMantenimiento}");
    Console.WriteLine($"Fuera de Servicio: {totalFueraServicio}"); 
    }
}