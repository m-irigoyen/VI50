using UnityEngine;
using System.Collections;

public class Pendulum : MonoBehaviour {

    public float angle = 30.0f;
    public float speed = 1.5f;
    public bool lateral = false;

    bool swinging;

    Quaternion qStart, qEnd;
    private float startTime;

    void Start()
    {
        

        this.swinging = true;
        if (this.lateral)
        {
            qStart = Quaternion.AngleAxis(angle, Vector3.right);
            qEnd = Quaternion.AngleAxis(-angle, Vector3.right);
            //qStart = Quaternion.AngleAxis(angle, Vector3.right);
            //qEnd = Quaternion.AngleAxis(-angle, Vector3.right);
        }
        else
        {
            qStart = Quaternion.AngleAxis(angle, new Vector3(0,0,1));
            qEnd = Quaternion.AngleAxis(-angle, new Vector3(0, 0, 1));
        }
    }

    void Update()
    {
        if (this.swinging == true)
        {
            startTime += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(qStart, qEnd, (Mathf.Sin(startTime * speed) + 1.0f) / 2.0f);
            //transform.right = new Vector3(0, 0, 1);
        }
        if (this.swinging == false)
        {
            resetTimer();
        }
    }

    void resetTimer()
    {
        startTime = 0.0f;
    }
}
