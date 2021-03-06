﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRifle : IWeapon {

	public WeaponRifle() { }

    protected override void DoShowBulletEffect(ICharacter theTarget)
    {
        ShowBulletEffect(theTarget.GetPosition(), 0.5f, 0.2f);
    }

    protected override void DoShowSoundEffect()
    {
        ShowSoundEffect("RifleShot");
    }
}
