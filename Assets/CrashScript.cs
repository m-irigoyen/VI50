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
            Destroy(this.gameObject);
        }
    }
}
