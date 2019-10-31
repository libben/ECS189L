using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public class BoomerangMotion : MonoBehaviour
{
    [SerializeField] private float MaxForwardDistance = 15f;
    [SerializeField] private float MaxSidewaysDisplacement = 5f;
    [SerializeField] private float JourneyDuration = 5;
    private float TimeElapsedInJourney;
    private static Vector3 YAxis = new Vector3(0, 1, 0);
    [SerializeField] private float RotationSpeedInAngles = 360;
    // Update is called once per frame
    private Vector3 startingPosition;

    void Start()
    {
        Destroy(this.gameObject, JourneyDuration);
        startingPosition = gameObject.transform.position;
        this.TimeElapsedInJourney = 0f;
    }
    void Update()
    {
        var centerOfPrefab = gameObject.transform.position;
        gameObject.transform.RotateAround(centerOfPrefab, YAxis, RotationSpeedInAngles*Time.deltaTime);
        
        this.TimeElapsedInJourney += Time.deltaTime;
        /*if (this.TimeElapsedInJourney >= this.JourneyDuration) {
            print(this.TimeElapsedInJourney);
            print(this.JourneyDuration);
            Destroy(this.gameObject);
        }*/
        this.TimeElapsedInJourney = this.TimeElapsedInJourney % JourneyDuration;
        var percentJourneyDone = this.TimeElapsedInJourney/JourneyDuration;
        var radiansOfJourney = percentJourneyDone*2*Mathf.PI;
        var forwardDistance = -1*Mathf.Cos(radiansOfJourney)*MaxForwardDistance/2 + MaxForwardDistance/2;
        var sidewaysDisplacement = Mathf.Sin(radiansOfJourney)*MaxSidewaysDisplacement;
        var currentPosition = startingPosition;
        currentPosition.x += forwardDistance;
        currentPosition.z += sidewaysDisplacement;
        if (float.IsNaN(sidewaysDisplacement)) {
            print($"jduration: {JourneyDuration}, timeElpsd: {TimeElapsedInJourney}, %JrnyDn: {percentJourneyDone}, Radns: {radiansOfJourney}");
        }
        gameObject.transform.position = currentPosition;
    }
}
}