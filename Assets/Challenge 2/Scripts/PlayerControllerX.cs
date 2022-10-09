/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder crear varios objetos tipo perro
**/

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // variable GameObject
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {

        // Al presionar la tecla espacio en el teclado  creara un objeto de tipo perro
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        
    }
}
