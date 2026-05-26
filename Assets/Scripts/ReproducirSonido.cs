using UnityEngine;

public class ReproducirSonido : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource audioSource;

    public void EjecutarEvento()
    {
        if (audioSource != null)
        {
            audioSource.Play();

            Debug.Log("Sonido reproducido");
        }
    }
}