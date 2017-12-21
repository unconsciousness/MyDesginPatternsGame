using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ENUM_Weapon
{
	Null = 0,
	Gun = 1,
	Rifle = 2,
	Rocket = 3,
	Max,
}


public class Weapon
{
	//属性
	protected ENUM_Weapon m_emWeapon = ENUM_Weapon.Null;//类型
	protected int m_AtkValue = 0;//攻击力
	protected int m_AtkRange = 0;//攻击距离
	protected int m_AtkPlusValue = 0;//额外加成值

	public Weapon(ENUM_Weapon Type,int AtkValue,int AtkRange)
	{
		m_emWeapon = Type;
		m_AtkValue = AtkValue;
		m_AtkRange = AtkRange;
	}

	public ENUM_Weapon GetWeaponType()
	{
		return m_emWeapon;
	}

	//攻击目标
	public void Fire(ICharacter theTarget)
	{

	}

	//设置额外攻击力
	public void SetAtkPlusValue(int AtkPlusValue)
	{
		m_AtkPlusValue = AtkPlusValue;
	}

	//显示子弹特效
	public void ShowBulletEffect(Vector3 TargetPosition,float LineWidth,float DisplayTime)
	{
		
	}

	//显示枪口特效
	public void ShowShootEffect()
	{

	}

	//播放音效
	public void ShowSoundEffect(string ClipName)
	{
	
	}
}
