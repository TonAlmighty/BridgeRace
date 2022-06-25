using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BrickType
{
    Red, Blue, Green
}
public class ChooseMaterial : MonoBehaviour
{
    public static Color SetColor(BrickType brickType)
    {
        switch (brickType)
        {
            case BrickType.Red:
                return Color.red;
            case BrickType.Blue:
                return Color.blue;
            case BrickType.Green:
                return Color.green;
            default:
                return Color.grey;
        }
    }
}
