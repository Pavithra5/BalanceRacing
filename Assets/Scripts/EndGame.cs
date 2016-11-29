using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	//Called when a box collider trigger is activated
    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if(collisionInfo.CompareTag("Collidable"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
