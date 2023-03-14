using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //call the restart the game function
        StartCoroutine(restartGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to restart game
    IEnumerator restartGame()
    {
        //wait for 4 seconds
        yield return new WaitForSeconds(4f);
        //reload the game
        SceneManager.LoadScene("SampleScene");
    }
}
