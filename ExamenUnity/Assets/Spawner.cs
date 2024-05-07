using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject explosionPrefab;  // Prefab de la explosión

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que colisionó tiene la etiqueta "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            Explode();  // Llama a la función Explode
        }
    }

    void Explode()
    {
        // Instancia la explosión en la posición del cubo
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        // Desactiva el cubo
        gameObject.SetActive(false);
    }
}
