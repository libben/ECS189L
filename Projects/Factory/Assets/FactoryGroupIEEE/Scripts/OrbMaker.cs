using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public class OrbMaker : MonoBehaviour, IFactorySpell
{
    [SerializeField] 
    private GameObject Prefab;

    public GameObject Make() 
    {
        var orb = Instantiate(this.Prefab, this.gameObject.transform);
        orb.AddComponent<OrbMotion>();
        return orb;
    }
}
}