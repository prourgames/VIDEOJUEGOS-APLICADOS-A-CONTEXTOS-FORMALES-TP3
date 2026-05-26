using UnityEngine;

public class DestruirTerrain : MonoBehaviour
{
    [Header("Terrain")]
    public Terrain terrain;

    public void EjecutarEvento()
    {
        if (terrain != null)
        {
            Destroy(terrain.gameObject);

            Debug.Log("Terrain destruido");
        }
    }
}