using UnityEngine;
using System.Collections;

public class RollController : MonoBehaviour {

    private GameObject controllerNode;
    public float speed;
    
    void Start()
    {
        controllerNode = GameObject.Find("HeadNode");
    }

	// Update is called once per frame
	void Update () {
        float roll = controllerNode.transform.eulerAngles.z;
        roll = (roll > 180) ? roll - 360 : roll;

        this.gameObject.transform.Translate(new Vector3(-speed * roll * Time.deltaTime,0,0));
        //this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x,
          //                                                  this.gameObject.transform.eulerAngles.y,
            //                                                roll);
	}
}
