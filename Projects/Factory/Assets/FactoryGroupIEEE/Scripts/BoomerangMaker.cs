using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public class BoomerangMaker : MonoBehaviour, IFactorySpell
{
    [SerializeField] private GameObject prefab;

    public GameObject Make() {
        var boomerang = Instantiate(prefab);
        boomerang.AddComponent<BoomerangMotion>();
        return boomerang;
    }
}
}