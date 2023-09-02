using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_Tareas
{
    
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
        public int ID { get; }
        public string Nombre { get; }
        public string Operacion { get; }
        public EstadoProceso EstadoActual { get; set; }
        public double Resultado { get; set; }

        public bool EsOperacion => Operacion != "Texto";

        public ProcesoEstado(string nombre, string operacion)
        {
            ID = new Random().Next(1, 1000);
            Nombre = nombre;
            Operacion = operacion;
            Resultado = 0;
        }

        public override string ToString()
        {
            return $"{Nombre} ({EstadoActual})";
        }




    }
}
