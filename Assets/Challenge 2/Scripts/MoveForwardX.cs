/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder mover el perro, para ser desplazado en línea recta
**/

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{

    // Variable tipo float que guarda la velovidad
    public float speed;



    // Update is called once per frame
    void Update()
    {
        // Ayuda a mover en linea recta al objeto de tipo perro.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
