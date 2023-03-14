using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject GameManager, start_menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to attack to the onclick of the start button
    public void StartButton()
    {
        //turn off the tart menu
        start_menu.SetActive(false);
        //turn on the game
		GameManager.SetActive(true);
	}

	//function to attack to the onclick of the exit button
	public void ExitButton()
    {
        //close the game
        Application.Quit();
    }
}
