using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        int index = SceneManager.GetActiveScene().buildIndex + 1;

        SceneManager.LoadScene(index);
    }
}
