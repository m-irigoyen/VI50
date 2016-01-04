using UnityEngine;
using System.Collections;

public class ChangScenes : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Application.LoadLevel("Labyrinth");
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            Application.LoadLevel("Sorter");
        }
        else if (Input.GetKeyDown(KeyCode.F3))
        {
            Application.LoadLevel("TestScene");
        }
        else if (Input.GetKeyDown(KeyCode.F4))
        {
            Application.LoadLevel("PlaneScene");
        }
    }
}
