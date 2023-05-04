using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int index = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(index);
    }
}
