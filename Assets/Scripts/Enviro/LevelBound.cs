using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBound : MonoBehaviour
{
    // Start is called before the first frame update
    public static float LeftSide = -6.0f;
    public static float RightSide = 5.0f;
    public static float LeftSideobs = -6.0f;
    public static float RightSideobs = 1.0f;
    public float InternalLeft, InternalRight, RightSideObs, LeftSideObs;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalLeft = LeftSide;
        InternalRight = RightSide;
        LeftSideObs = LeftSideobs;
        RightSideObs = RightSideobs;

    }
}
