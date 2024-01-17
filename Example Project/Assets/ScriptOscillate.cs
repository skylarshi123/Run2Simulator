using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOscillate : MonoBehaviour
{
    private Vector3 origin;

    [SerializeField] private float rotationSpeed = 50.0f; // Rotation speed in degrees per second

    void Start()
    {
        origin = new Vector3(x: 0, y: 5, z: 0);
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -1) * rotationSpeed * Time.deltaTime);
    }
}
