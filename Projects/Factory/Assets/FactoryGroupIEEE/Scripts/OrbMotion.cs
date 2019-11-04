using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public class OrbMotion : MonoBehaviour
{
    [SerializeField]
    private float Raidus = 5.0f;
    [SerializeField]
    private float LifeTime = 7.0f;
    private Vector3 Center;

    void Start()
    {
        this.Center = new Vector3(0.0f, 7.0f, 0.0f);
        Destroy(this.gameObject, this.LifeTime);
    }

    void Update()
    {
        float time = Time.time;
        var position = new Vector3(0.0f, 0.0f, 0.0f);
        position.x = this.Raidus * Mathf.Cos(time);
        position.z = this.Raidus * Mathf.Sin(time);
        this.transform.position = (position + this.Center);
    }
}
}