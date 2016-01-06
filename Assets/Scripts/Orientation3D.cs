using UnityEngine;
using System.Collections;

public class Orientation3D : MonoBehaviour 
{

	public Transform target;
	public float rotationYOffset;
	public float rotationXOffset;

	// Use this for initialization
	void Start () 
	{
		if (target == null)
			target = GameObject.Find("HandNode").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 rot = target.transform.eulerAngles;
		rot.y = target.transform.position.x * rotationYOffset;
		rot.x = target.transform.position.z * rotationXOffset;
		this.transform.eulerAngles = rot;
	}
}
