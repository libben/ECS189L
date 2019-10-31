using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public class BoomerangMotion : MonoBehaviour
{
    private static Vector3 YAxis = new Vector3(0, 1, 0);
    float rotationSpeedInRadians = 2*Mathf.PI;
    [SerializeField] private float RotationSpeed;
    // Update is called once per frame
    void Update()
    {
        var centerOfPrefab = gameObject.transform.position;
        gameObject.transform.RotateAround(centerOfPrefab, YAxis, rotationSpeedInRadians*Time.deltaTime);
        
    }
}
}