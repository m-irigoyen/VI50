using UnityEngine;
using System.Collections;

public class MazeBall : MonoBehaviour {

    bool active;

    public Transform target;
    public AudioSource buzzer;
    public AudioSource coin;
    
    Transform handTarget;

    public Material colorActive;
    public Material colorInactive;

    public float positionOffset;

	// Use this for initialization
	void Start ()
    {
        this.setActive(false);
        this.coin.volume = 1;
        this.buzzer.volume = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 targetPos = GameObject.Find("HandNode").transform.position;
        targetPos *= positionOffset;
        targetPos.z = 10;
        this.transform.position = targetPos;

        if (Input.GetButtonDown("Vertical"))
        {
            if(Input.GetAxis("Vertical") > 0)
            {
                positionOffset = positionOffset +5;
            }
            else
            {
                positionOffset = positionOffset - 5;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            this.setActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "StartZone")
        {
            this.setActive(true);
        }
        else if (other.gameObject.name == "FinishZone")
        {
            //TODO: afficher quelque chose
            this.coin.Play();
            this.setActive(false);
        }
    }

    public void setActive(bool active)
    {
    	if (this.active != active)
    	{
			this.active = active;
			if (this.active)
			{
				this.GetComponent<Renderer>().material = colorActive;
				
			}
			else
			{
				this.buzzer.Play();
				this.GetComponent<Renderer>().material = colorInactive;
			}
				
    	}
        
    }
}
