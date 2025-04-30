using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider2D)
    {
        SceneManager.LoadScene(2);
    }
}
