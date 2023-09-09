using System;

namespace Administrador_Tareas
{
    // Un enumerado para los posibles estados de proceso
    public enum EstadoProceso
    {
        Creado,
        Iniciado,
        Ejecutado,
        Bloqueado,
        Listo,
        Finalizado
    }

    public class ProcesoEstado
    {
        //Propiedades de la clase
        public int ID { get; }//Un identificador único para cada estado
        public string Nombre { get; set; }//El nombre del estado
        public string Operacion { get; }//El tipo de operación (Suma, Resta, etc.)
        public EstadoProceso EstadoActual { get; set; }//El estado actual del proceso
        public double Resultado { get; set; }//El resultado de la operación (si es aplicable)

        public bool EsOperacion => Operacion != "Texto";

        //Constructor de la clase ProcesoEstado
        public ProcesoEstado(string nombre, string operacion)
        {
            ID = new Random().Next(1, 1000);
            Nombre = nombre;
            Operacion = operacion;
            Resultado = 0;//Inicialmente, el resultado es 0
        }

        //Un método ToString personalizado para mostrar el estado en el ListBox
        public override string ToString()
        {
            return $"{Nombre} ({EstadoActual})";
        }




    }
}
