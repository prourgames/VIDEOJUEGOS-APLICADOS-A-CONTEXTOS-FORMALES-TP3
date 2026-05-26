using UnityEngine;

public class MovimientoAuto : MonoBehaviour
{
    [Header("Velocidades")]
    public float velocidadMaxima = 15f;
    public float velocidadReversa = 8f;

    [Header("Aceleracion y Frenado")]
    public float aceleracion = 10f;
    public float desaceleracion = 5f;

    [Header("Giro")]
    public float velocidadGiro = 120f;

    private float velocidadActual = 0f;

    void Update()
    {
        // -------------------------
        // INPUT
        // -------------------------

        float objetivoVelocidad = 0f;

        // Avanzar
        if (Input.GetKey(KeyCode.W))
        {
            objetivoVelocidad = velocidadMaxima;
        }

        // Reversa
        if (Input.GetKey(KeyCode.S))
        {
            objetivoVelocidad = -velocidadReversa;
        }

        // -------------------------
        // ACELERACION SUAVE
        // -------------------------

        float velocidadCambio = (objetivoVelocidad != 0)
            ? aceleracion
            : desaceleracion;

        velocidadActual = Mathf.MoveTowards(
            velocidadActual,
            objetivoVelocidad,
            velocidadCambio * Time.deltaTime
        );

        // -------------------------
        // MOVIMIENTO
        // -------------------------

        transform.Translate(Vector3.forward * velocidadActual * Time.deltaTime);

        // -------------------------
        // GIRO
        // -------------------------

        float giro = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            giro = -1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            giro = 1f;
        }

        // El auto gira menos si está casi detenido
        if (Mathf.Abs(velocidadActual) > 0.1f)
        {
            transform.Rotate(Vector3.up * giro * velocidadGiro * Time.deltaTime);
        }
    }
}