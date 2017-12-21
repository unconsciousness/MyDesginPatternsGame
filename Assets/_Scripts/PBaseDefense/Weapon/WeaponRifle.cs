using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRifle : IWeapon {

	public WeaponRifle() { }

	public override void Fire(ICharacter theTarget)
	{
		//显示武器特效和音效
		ShowShootEffect();
		ShowBulletEffect(theTarget.GetPosition(), 0.5f, 0.2f);
		ShowSoundEffect("RifleShot");

		//攻击直接命中
		theTarget.UnderAttack(m_WeaponOwner);
	}
}
