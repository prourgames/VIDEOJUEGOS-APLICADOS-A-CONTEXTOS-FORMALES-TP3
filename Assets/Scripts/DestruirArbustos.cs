using UnityEngine;

public class DestruirArbustos : MonoBehaviour
{
    public void EjecutarEvento()
    {
        GameObject[] arbustos = GameObject.FindGameObjectsWithTag("Arbusto");

        foreach (GameObject arbusto in arbustos)
        {
            Destroy(arbusto);
        }

        Debug.Log("Todos los arbustos fueron destruidos");
    }
}