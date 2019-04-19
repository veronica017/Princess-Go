using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    [Header("Connect to some scene")]
    public string goToTheScene;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            SceneManager.LoadScene(goToTheScene);
    }

}