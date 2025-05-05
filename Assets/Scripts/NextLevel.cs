using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string Scene2; // Define o nome da cena a carregar

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            SceneManager.LoadScene(Scene2);
        }
    }
   
}
