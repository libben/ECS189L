﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IEEE {
public enum Spells { Boomerang, Spray, Orb }
[RequireComponent(typeof(BoomerangMaker))]
[RequireComponent(typeof(SprayMaker))]
[RequireComponent(typeof(OrbMaker))]
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
				this.GetComponent<SprayMaker>().Make();
                break;
            case Spells.Orb:
                this.GetComponent<OrbMaker>().Make();
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            BuildSpell(Spells.Boomerang);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            BuildSpell(Spells.Spray);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            BuildSpell(Spells.Orb);
        }
    }
}
}