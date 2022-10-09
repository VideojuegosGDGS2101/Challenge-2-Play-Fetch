/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder crear objetos con ayuda de los prefabs
los objetos de tipo pelota
**/

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{

    // Array GameObject[]
    public GameObject[] ballPrefabs;

    // Variable tipo float
    private float spawnLimitXLeft = -22;
    
    // Variable tipo float
    private float spawnLimitXRight = 7;
    
    // Variable tipo float spawnPosY
    private float spawnPosY = 30;

    // Variable tipo float startDelay
    private float startDelay = 1.0f;

    // variable tipo float spawnInterval
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Al iniciar invoca la apariciion de una pelota
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {   
        // Ayuda a crear las pelotas de diferentes colores
        int bola = Random.Range(0, 3);


        // Genera  la bola aleatorio y posición de generación aleatoriamente
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Se instancia la ubicacion de la pelota aleatoriamente
        Instantiate(ballPrefabs[bola], spawnPos, ballPrefabs[bola].transform.rotation);
    }

}
