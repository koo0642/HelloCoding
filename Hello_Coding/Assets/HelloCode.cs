using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        float distance = Getdistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서(5,6)까지의 거리 : " + distance);

    }
    float Getdistance(float X1, float Y1, float X2, float Y2)
    {
        float width = X2 - X1;
        float heigth = Y2 - Y1;

        float distance = width * width + heigth * heigth;
        distance = Mathf.Sqrt(distance);

        return distance;
    }


}
