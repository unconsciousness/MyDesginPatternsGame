using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRocket : IWeapon {

	public WeaponRocket() { }

	public override void Fire(ICharacter theTarget)
	{
		//显示武器特效和音效
		ShowShootEffect();
		ShowBulletEffect(theTarget.GetPosition(), 0.8f, 0.5f);
		ShowSoundEffect("RocketShot");

		//攻击直接命中
		theTarget.UnderAttack(m_WeaponOwner);
	}
}
