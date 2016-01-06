using UnityEngine;
using System.Collections;

public class SorterSpawner : MonoBehaviour
{
    SorterGamemode gameMode;
    SorterColors sorterColors;

    public GameObject sorterBall; // Reference to the ball
    public float delaySpawn;
    public bool delayFirst;
    //public SorterColors.BallColor color;

    float timeBeforeNextSpawn;

	// Use this for initialization
	void Start ()
    {
        this.timeBeforeNextSpawn = this.delaySpawn;

        gameMode = ((GameObject)GameObject.FindGameObjectWithTag("gamemode")).GetComponent<SorterGamemode>();
        sorterColors = gameMode.GetComponent<SorterColors>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        this.timeBeforeNextSpawn -= Time.deltaTime;
	
		if (this.delayFirst)
		{
			delayFirst = false;
			this.timeBeforeNextSpawn = this.delaySpawn/2;
		}
        else if (this.timeBeforeNextSpawn < 0.0f)
        {
            this.timeBeforeNextSpawn = this.delaySpawn;

            SorterColors.BallColor c = sorterColors.getRandomColor();
            this.spawnBall(c);
            //Debug.Log("Spawning color " + c);
        }
	}

    public void spawnBall(SorterColors.BallColor color)
    {
        GameObject ball = (GameObject)Instantiate(sorterBall, this.transform.position, Quaternion.identity);
        ball.GetComponent<SorterBall>().setColor(color, sorterColors.getMaterial(color));
    }
}
