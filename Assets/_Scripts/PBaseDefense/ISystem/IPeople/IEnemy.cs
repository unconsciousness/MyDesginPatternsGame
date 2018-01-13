using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnemy : ICharacter
{
	int m_Value=0;
	//public override void Attack(ICharacter theTarget)
	//{
	//	//设置武器的额外攻击力加成
	//	//SetWeaponAtkPlusValue(m_Value.GetAtkPlusValue());

	//	//武器攻击
	//	WeaponAttackTarget(theTarget);
	//}

	//public override void UnderAttack(ICharacter Attacker)
	//{
	//	throw new System.NotImplementedException();
	//}

	//没有使用桥接模式情况下攻击函数的写法
	/*
	public override void Attack(ICharacter theTarget)
	{
		//发射特效
		m_Waepon.ShowShootEffect();
		int AtkPlusValue = 0;

		//按当前武器决定攻击方式
		switch (m_Waepon.GetWeaponType())
		{
			case ENUM_Weapon.Gun:
				//显示武器特效和音效
				m_Waepon.ShowBulletEffect(theTarget.GetPosition(), 0.03f, 0.2f);
				m_Waepon.ShowSoundEffect("GunShot");
				//有概率增加额外加成
				AtkPlusValue = GetAtkPlusValue(5, 20);
				break;
			case ENUM_Weapon.Rifle:
				//显示武器特效和音效
				m_Waepon.ShowBulletEffect(theTarget.GetPosition(), 0.5f, 0.2f);
				m_Waepon.ShowSoundEffect("RifleShot");
				//有概率增加额外加成
				AtkPlusValue = GetAtkPlusValue(10, 25);
				break;
			case ENUM_Weapon.Rocket:
				//显示武器特效和音效
				m_Waepon.ShowBulletEffect(theTarget.GetPosition(), 0.8f, 0.5f);
				m_Waepon.ShowSoundEffect("RocketShot");
				//有概率增加额外加成
				AtkPlusValue = GetAtkPlusValue(15, 30);
				break;
		}
		m_Waepon.SetAtkPlusValue(AtkPlusValue);
		m_Waepon.Fire(theTarget);
	}
	*/


	/// <summary>
	/// 获取额外的加成值
	/// </summary>
	/// <param name="Rate">百分之Rate的成功率</param>
	/// <param name="AtkValue">成功获取时增加的值</param>
	private int GetAtkPlusValue(int Rate, int AtkValue)
	{
		int RandValue = UnityEngine.Random.Range(0, 100);
		if (Rate > RandValue)
			return AtkValue;
		return 0;
	}
}
