using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : IWeapon
{
    public Cannon() { }



    protected override void DoShowBulletEffect(ICharacter theTarget)
    {
        ShowBulletEffect(theTarget.GetPosition(), 0.1f, 0.5f);
    }

    protected override void DoShowSoundEffect()
    {
        ShowSoundEffect("CannonShot");
    }
}
