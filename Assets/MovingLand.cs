using UnityEngine;
using System.Collections;

public class MovingLand : MonoBehaviour {
    
    public Transform canyonPrefab;
    public float speed;
    public float acceleration;

	// Use this for initialization
	void Start () {
        Transform firstCanyon = Instantiate(canyonPrefab);

        firstCanyon.parent = this.transform;
        firstCanyon.transform.localPosition = new Vector3(0, 0, 0);

        Vector3 newPos = new Vector3(firstCanyon.transform.Find("Anchor").transform.position.x,
                                        firstCanyon.transform.Find("Anchor").transform.position.y,
                                        firstCanyon.transform.Find("Anchor").transform.position.z);

        Transform secondCanyon = (Transform)Instantiate(canyonPrefab, newPos, new Quaternion());
        secondCanyon.parent = this.transform;
        secondCanyon.Find("TriggerWall").GetComponent<SpawnerWall>().setLastCanyon(firstCanyon.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        this.speed = Mathf.Min(speed + Time.deltaTime * acceleration,500);
	}

    public void Stop()
    {
        this.speed = 0;
        this.acceleration = 0;
    }
}
