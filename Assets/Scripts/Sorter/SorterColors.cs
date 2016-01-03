using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class SorterColors : MonoBehaviour
{
    public List<Material> materials;

    System.Random rnd;

    void Start()
    {
        rnd = new System.Random();
    }

    // ball color enum
    public enum BallColor
    {
        blue = 0,
        red,
        green,
        purple
    }

    public Material getMaterial(BallColor color)
    {
        return this.materials[(int)color];
    }

    public BallColor getRandomColor()
    {
        return (BallColor)rnd.Next(0, 4);
    }
}
