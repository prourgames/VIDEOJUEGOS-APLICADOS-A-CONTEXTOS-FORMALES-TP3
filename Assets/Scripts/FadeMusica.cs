using UnityEngine;

public class FadeMusica : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource musica;

    [Header("Fade")]
    public float velocidadFade = 0.5f;

    private bool haciendoFade = false;

    void Update()
    {
        if (haciendoFade && musica.volume > 0)
        {
            musica.volume -= velocidadFade * Time.deltaTime;

            if (musica.volume < 0)
            {
                musica.volume = 0;
            }
        }
    }

    public void EjecutarEvento()
    {
        haciendoFade = true;

        Debug.Log("La música comenzó a desvanecerse");
    }
}