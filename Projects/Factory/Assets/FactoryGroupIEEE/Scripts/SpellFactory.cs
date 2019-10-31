using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public enum Spells { Boomerang, Spray, Heal }
[RequireComponent(typeof(BoomerangMaker))]
public class SpellFactory : MonoBehaviour
{
    private void BuildSpell(Spells spell)
    {
        switch(spell) {
            case Spells.Boomerang:
                var boomerang = this.GetComponent<BoomerangMaker>().Make();
                boomerang.transform.position = this.transform.position;
                break;
            case Spells.Spray:
                break;
            case Spells.Heal:
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("1")) {
            BuildSpell(Spells.Boomerang);
        }
        if (Input.GetButton("2")) {
            BuildSpell(Spells.Spray);
        }
        if (Input.GetButton("3")) {
            BuildSpell(Spells.Heal);
        }
    }
}
}