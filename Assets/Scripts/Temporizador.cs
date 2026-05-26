using TMPro;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    [Header("Tiempo")]
    public float tiempoInicial = 60f;

    [Header("UI")]
    public TextMeshProUGUI textoTiempo;

    private float tiempoActual;

    void Start()
    {
        tiempoActual = tiempoInicial;
    }

    void Update()
    {
        if (tiempoActual > 0)
        {
            tiempoActual -= Time.deltaTime;

            if (tiempoActual < 0)
            {
                tiempoActual = 0;
            }

            ActualizarTexto();
        }
    }

    void ActualizarTexto()
    {
        int minutos = Mathf.FloorToInt(tiempoActual / 60);
        int segundos = Mathf.FloorToInt(tiempoActual % 60);

        textoTiempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");
    }
}