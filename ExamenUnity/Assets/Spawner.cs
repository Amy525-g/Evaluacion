using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject explosionPrefab;  // Prefab de la explosi�n

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que colision� tiene la etiqueta "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            Explode();  // Llama a la funci�n Explode
        }
    }

    void Explode()
    {
        // Instancia la explosi�n en la posici�n del cubo
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        // Desactiva el cubo
        gameObject.SetActive(false);
    }
}
