using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {

    bool next = false;

	private void OnTriggerEnter2D(Collider2D collision)
    {
        next = true;
    }

    public void Update()
    {
        if (next && Input.GetButtonDown("Interact"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
