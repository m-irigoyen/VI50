using UnityEngine;
using System.Collections.Generic;

public class SorterBall : MonoBehaviour
{
    SorterGamemode gameMode;

    // public variables
    public float killAltitude;

    // private variables
    SorterColors.BallColor color;

    // Use this for initialization
    void Start()
    {
        gameMode = ((GameObject)GameObject.FindGameObjectWithTag("gamemode")).GetComponent<SorterGamemode>();

        if (gameMode == null)
            Debug.Log("SorterBall : couldn't find gamemode");

        this.gameObject.name = "SorterBall";
   	}
	
	// Update is called once per frame 
	void Update ()
    {
        if (this.transform.position.y < killAltitude)
            Destroy(this.gameObject);
	}

    public void setColor(SorterColors.BallColor color, Material m)
    {
        if (this.GetComponent<Renderer>().material == null)
            Debug.Log("SorterBall : something is wrong here");
        this.color = color;
        this.GetComponent<Renderer>().material = m;
    }

    public SorterColors.BallColor getBallColor()
    {
        return this.color;
    }
}
