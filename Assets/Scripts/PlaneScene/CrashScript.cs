using UnityEngine;
using System.Collections;

public class CrashScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collision");
        if(collider.gameObject.tag == "Terrain")
        {
            GameObject.Find("LandManager").GetComponent<MovingLand>().Stop();
            GameObject.Find("Pop").GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }
}
