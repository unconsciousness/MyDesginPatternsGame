using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGun : IWeapon
{
	public WeaponGun() { }

	//攻击目标
	public override void Fire(ICharacter theTarget)
	{
		//显示武器特效和音效
		ShowShootEffect();
		ShowBulletEffect(theTarget.GetPosition(), 0.03f, 0.2f);
		ShowSoundEffect("GunShot");

		//攻击直接命中
		theTarget.UnderAttack(m_WeaponOwner);
	}
}
