using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //gamer manager will accept 2 game objects a script and text
    public GameObject fish_prefab;
    public GameObject bomb_prefab;
    public PlayerScript playerS;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        //spawn a fish every 2 seconds
        InvokeRepeating("SpawnFish", 2, 2);
        //spawn a bomb every 6 seconds
		InvokeRepeating("SpawnBomb", 6, 6);
	}

    // Update is called once per frame
    void Update()
    {
        //update the score text
        text.text = playerS.score.ToString();
    }

    void SpawnFish()
    {
        //roll a random spot for the fish to spawn between the bounds
        float tPos = Random.Range(-9.5f, 8.65f);
        //spawn the fish at the spot just given and above the screen
        Instantiate(fish_prefab, new Vector3(tPos, 6.5f, 0), Quaternion.identity);
    }

	void SpawnBomb()
	{
		//roll a random spot for the bomb to spawn between the bounds
		float tPos = Random.Range(-9.5f, 8.65f);
		//spawn the bomb at the spot just given and above the screen
		Instantiate(bomb_prefab, new Vector3(tPos, 5.5f, 0), Quaternion.identity);
	}

	public void StopSpwaning()
    {
        //stop the spawning of bombs and fish
        CancelInvoke();
		CancelInvoke();
	}
}
