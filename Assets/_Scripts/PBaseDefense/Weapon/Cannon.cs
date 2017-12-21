using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : IWeapon
{
	public Cannon() { }


	public override void Fire(ICharacter theTarget)
	{
		//显示武器特效和音效
		ShowShootEffect();
		ShowBulletEffect(theTarget.GetPosition(), 0.1f, 0.5f);
		ShowSoundEffect("CannonShot");

		//攻击直接命中
		theTarget.UnderAttack(m_WeaponOwner);
	}
}
