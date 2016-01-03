using UnityEngine;
using System.Collections;

public class MazeBall : MonoBehaviour {

    bool active;

    public Transform target;
    Transform handTarget;

    public Material colorActive;
    public Material colorInactive;

    public float positionOffset;

	// Use this for initialization
	void Start ()
    {
        this.setActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 targetPos = GameObject.Find("HandNode").transform.position;
        targetPos *= positionOffset;
        targetPos.z = 10;
        this.transform.position = targetPos;
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
    }

    public void setActive(bool active)
    {
        this.active = active;
        if (this.active)
            this.GetComponent<Renderer>().material = colorActive;
        else
            this.GetComponent<Renderer>().material = colorInactive;
    }
}
