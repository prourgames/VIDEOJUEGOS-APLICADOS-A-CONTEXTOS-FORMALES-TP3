using System.Collections.Generic;
using UnityEngine;

public class DirectorEventos : MonoBehaviour
{
    [System.Serializable]
    public class EventoTemporal
    {
        [Header("Tiempo")]
        public int minutos;
        public int segundos;

        [Header("Evento")]
        public MonoBehaviour scriptEvento;

        [HideInInspector]
        public bool ejecutado = false;
    }

    [Header("Tiempo Maximo")]
    public int minutosMaximos = 5;
    public int segundosMaximos = 0;

    [Header("Eventos")]
    public List<EventoTemporal> eventos = new List<EventoTemporal>();

    private float tiempoActual;

    void Update()
    {
        tiempoActual += Time.deltaTime;

        int minutosActuales = Mathf.FloorToInt(tiempoActual / 60);
        int segundosActuales = Mathf.FloorToInt(tiempoActual % 60);

        foreach (EventoTemporal evento in eventos)
        {
            if (!evento.ejecutado)
            {
                if (minutosActuales >= evento.minutos &&
                    segundosActuales >= evento.segundos)
                {
                    evento.ejecutado = true;

                    // Verificar que exista el script
                    if (evento.scriptEvento != null)
                    {
                        evento.scriptEvento.SendMessage("EjecutarEvento");
                    }
                }
            }
        }

        // Fin del tiempo máximo
        if (minutosActuales >= minutosMaximos &&
            segundosActuales >= segundosMaximos)
        {
            enabled = false;
        }
    }
}