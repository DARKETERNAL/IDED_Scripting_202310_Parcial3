using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableOBJ : MonoBehaviour // Define la clase llamada "PoolableOBJ" que implementa la interfaz "Ipoolable" y hereda de "MonoBehaviour"
{
    // M�todo que se encarga de devolver el objeto a la pool
    public void Recycle()
    {
        // Establece la velocidad del objeto en cero y lo desactiva
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.SetActive(false);
    }

    // M�todo que configura el comportamiento del objeto en la pool
    void Ipoolable.SetUp(float i)
    {
        // Inicia una corrutina que desactivar� el objeto despu�s de un tiempo determinado por "i"
        StartCoroutine(DeactivateOBJ(i));
    }

    // Corrutina que desactiva el objeto despu�s de un tiempo determinado por "i"
    private IEnumerator DeactivateOBJ(float i)
    {
        yield return new WaitForSeconds(i);
        Recycle();
    }
}
