using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour

{
    void OnTriggerEnter2D(Collider2D door)
    {
    if (door.gameObject.tag == "Player")
    {
    SceneManager.LoadScene (1);
    }
    }
}
