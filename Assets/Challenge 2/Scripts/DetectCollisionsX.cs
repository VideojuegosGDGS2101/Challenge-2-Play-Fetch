/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder detectar las colisiones, cuando una pelota
toque un perro y poder eliminarla
**/

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    // Funcion que ayuda a destruir los objetos tanto perro como pelota
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
