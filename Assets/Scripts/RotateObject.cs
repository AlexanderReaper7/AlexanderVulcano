using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

float rotationX = 0;
float rotationY = 5.0f;
float rotationZ = 0;

void Update () {
    transform.Rotate(new Vector3(rotationX,rotationY,rotationZ));
}
}
