using UnityEngine;

public class CambiarSkybox : MonoBehaviour
{
    [Header("Nuevo Skybox")]
    public Material nuevoSkybox;

    [Header("Luz Direccional")]
    public Light directionalLight;

    public void EjecutarEvento()
    {
        // Cambiar skybox
        if (nuevoSkybox != null)
        {
            RenderSettings.skybox = nuevoSkybox;

            // Actualizar iluminación
            DynamicGI.UpdateEnvironment();
        }

        // Destruir luz
        if (directionalLight != null)
        {
            Destroy(directionalLight.gameObject);
        }

        Debug.Log("Skybox cambiado y luz destruida");
    }
}