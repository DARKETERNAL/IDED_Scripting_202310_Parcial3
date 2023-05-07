using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hereda de "PoolBase"
public class PoolHardObstacle : PoolBase
{
    // Define una propiedad est�tica que representa una �nica instancia de la clase "PoolHardObstacle"
    public static PoolHardObstacle Instance { get; private set; } = null;

    // M�todo que se ejecuta cuando se inicializa el objeto
    private void Awake()
    {
        // Si ya hay una instancia de "PoolHardObstacle", destruye este objeto y retorna
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        // Si no hay una instancia de "PoolHardObstacle", establece esta instancia como la instancia �nica
        Instance = this;
    }
}
