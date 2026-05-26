using UnityEngine;

public class DestruirArboles : MonoBehaviour
{
    public void EjecutarEvento()
    {
        GameObject[] arboles = GameObject.FindGameObjectsWithTag("Arbol");

        foreach (GameObject arbol in arboles)
        {
            Destroy(arbol);
        }

        Debug.Log("Todos los árboles fueron destruidos");
    }
}