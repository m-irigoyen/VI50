using UnityEngine;
using System.Collections;

public class SpawnerWall : MonoBehaviour {

    public Transform nextCanyon;

    private GameObject lastCanyon;

    void Update()
    {
        if (this.transform.position.z < GameObject.Find("Camera").transform.position.z)
        {
            //The last tile can be destroy
            Destroy(lastCanyon);
        }
    }

	void OnTriggerEnter (Collider other) {
	    if(other.name == "airplane_01")
        {
            //The plane has reached this wall: we have to spawn a new tile

            Debug.Log("collision with plane");

            //Spawn a new tile after this one
            Vector3 newPos = new Vector3(this.transform.parent.Find("Anchor").transform.position.x,
                                        this.transform.parent.Find("Anchor").transform.position.y,
                                        this.transform.parent.Find("Anchor").transform.position.z);
            GameObject newCanyon = (GameObject)Instantiate(nextCanyon, newPos ,new Quaternion());
            newCanyon.transform.parent = this.transform.parent.parent;
            newCanyon.transform.Find("TriggerWall").GetComponent<SpawnerWall>().setLastCanyon(this.transform.parent.gameObject);
            
        }
	}

    public void setLastCanyon(GameObject canyon)
    {
        this.lastCanyon = canyon;
    }
}
