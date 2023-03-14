using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField]
	//initalize varriables
	int speed;
	public int score = 0;
	public int life = 1;
	//refrence other scripts to use public values from them
	public GroundScript groundScript;
	public GameManager gameManager;
	//script accepts a game object
	public GameObject gameOver;


	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//right arrow key moves player right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
		//left arrow key moves player right
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
		}
		//get the curret x position
        float xPos = transform.position.x;
		//make it so xPos cant go out of the bounds
        xPos = Mathf.Clamp(xPos, -9.5f,8.65f);
		//make it so we can only move in the x direction
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

		//of we are out of lives (we only have one) stop spwaning enemies
		if (life <= 0)
		{
			gameManager.StopSpwaning();
		}
	}

	//if two items collide function
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//if the item has the tag Fish 
		if(collision.tag == "Fish")
        {
			//add one to the score
            score += 1;
			//delete the item
            Destroy(collision.gameObject);
        }

		//if the item has the tag Bomb
		if (collision.tag == "Bomb")
		{
			//remove 1 from life
			life -= 1;
			//delete the bomb
			Destroy(collision.gameObject);
			//make the Gameover text appear on the screen
			gameOver.SetActive(true);
		}
	}
}
