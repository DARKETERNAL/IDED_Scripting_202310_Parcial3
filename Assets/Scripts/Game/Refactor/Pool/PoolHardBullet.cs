using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Definimos una clase llamada "PoolBlueBullet" que hereda de "PoolBase"
public class PoolHardBullet : PoolBase
{
    // Define una propiedad est�tica que representa una �nica instancia de la clase "PoolBlueBullet"
    public static PoolHardBullet Instance { get; private set; } = null;

    // M�todo que se ejecuta cuando se inicializa el objeto
    private void Awake()
    {
        // Si ya hay una instancia de "PoolBlueBullet", destruye este objeto y retorna
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        // Si no hay una instancia de "PoolBlueBullet", establece esta instancia como la instancia �nica
        Instance = this;
    }
}
