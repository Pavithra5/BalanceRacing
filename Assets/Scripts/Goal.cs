using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    [SerializeField]
    private GameObject winner;

	void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.CompareTag( "Player"))
        {
             
             StartCoroutine(ShowWinScreen());

        }

    }

    private IEnumerator ShowWinScreen()
    {
        winner.SetActive(true);
       
        yield return new WaitForSeconds(3);
        winner.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
