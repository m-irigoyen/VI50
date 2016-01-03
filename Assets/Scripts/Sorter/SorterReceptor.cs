using UnityEngine;
using System.Collections;

public class SorterReceptor : MonoBehaviour
{
    public SorterColors.BallColor color;

    SorterGamemode gameMode;
    SorterColors sorterColors;


    // Use this for initialization
    void Start ()
    {
        gameMode = ((GameObject)GameObject.FindGameObjectWithTag("gamemode")).GetComponent<SorterGamemode>();
        sorterColors = gameMode.GetComponent<SorterColors>();

        this.GetComponent<Renderer>().material = sorterColors.getMaterial(color);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "SorterBall")
        {
            Debug.Log("BALL");
            if (other.gameObject.GetComponent<SorterBall>().getBallColor() == this.color)
            {
                Debug.Log("SAME COLOR");
                Destroy(other.gameObject);
            }
        }
    }
}
