using UnityEngine;
using System.Collections;

public class SorterPaddleChild : MonoBehaviour
{
    public GameObject referencePaddle;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (referencePaddle != null)
            this.transform.rotation = referencePaddle.transform.rotation;
	}
}
