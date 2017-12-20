using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISoldier : ICharacter
{
	//没有使用桥接模式情况下攻击函数的写法
	/*
	public override void Attack(ICharacter theTarget)
	{
		//发射特效
		m_Waepon.ShowShootEffect();

		//按当前武器决定攻击方式
		switch (m_Waepon.GetWeaponType())
		{
			case ENUM_Weapon.Gun:
				//显示武器特效和音效
				m_Waepon.ShowBulletEffect(theTarget.GetPosition(), 0.03f, 0.2f);
				m_Waepon.ShowSoundEffect("GunShot");
				break;
			case ENUM_Weapon.Rifle:
				//显示武器特效和音效
				m_Waepon.ShowBulletEffect(theTarget.GetPosition(), 0.5f, 0.2f);
				m_Waepon.ShowSoundEffect("RifleShot");
				break;
			case ENUM_Weapon.Rocket:
				//显示武器特效和音效
				m_Waepon.ShowBulletEffect(theTarget.GetPosition(), 0.8f, 0.5f);
				m_Waepon.ShowSoundEffect("RocketShot");
				break;
		}
		m_Waepon.Fire(theTarget);
	}
	*/
	public override void Attack(ICharacter theTarget)
	{
		throw new System.NotImplementedException();
	}
}
