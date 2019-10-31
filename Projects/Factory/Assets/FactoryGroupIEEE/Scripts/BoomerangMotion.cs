using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public class BoomerangMotion : MonoBehaviour
{
    private const float MaxForwardDistance = 30f;
    private const float MaxSidewaysDisplacement = 10f;
    private const float JourneyDuration = 4f;
    private float TimeElapsedInJourney = 0f;
    private static Vector3 YAxis = new Vector3(0, 1, 0);
    float rotationSpeedInRadians = 2*Mathf.PI;
    [SerializeField] private float RotationSpeed;
    // Update is called once per frame
    void Update()
    {
        var centerOfPrefab = gameObject.transform.position;
        gameObject.transform.RotateAround(centerOfPrefab, YAxis, rotationSpeedInRadians*Time.deltaTime);
        
        this.TimeElapsedInJourney += Time.deltaTime;
        this.TimeElapsedInJourney = this.TimeElapsedInJourney % this.JourneyDuration;
        var percentJourneyDone = this.TimeElapsedInJourney/this.JourneyDuration;
        var radiansOfJourney = percentJourneyDone*2*Mathf.PI;
        var forwardDistance = Mathf.Sin(radiansOfJourney)*MaxForwardDistance/2 + MaxForwardDistance/2;
        var sidewaysDisplacement = Mathf.Sin(radiansOfJourney)*MaxSidewaysDisplacement;
        centerOfPrefab.x = forwardDistance*this.transform.forward;
        centerOfPrefab.z = sidewaysDisplacement;
        gameObject.transform.position = centerOfPrefab;
    }
}
}