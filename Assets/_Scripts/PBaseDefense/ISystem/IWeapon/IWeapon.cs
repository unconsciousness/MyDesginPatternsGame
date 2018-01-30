using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IWeapon
{


	//属性
	protected int m_AtkValue = 0;//攻击力
	protected int m_AtkRange = 0;//攻击距离
	protected int m_AtkPlusValue = 0;//额外加成值

	//
	protected GameObject m_GameObject = null;//显示的Unity模型
	protected ICharacter m_WeaponOwner = null;//武器的拥有者

	//发射特效
	protected float m_EffectDisplayTime = 0;
	protected ParticleSystem m_Particles;
	protected LineRenderer m_Line;
	protected AudioSource m_Audio;
	protected Light m_Light;

	//显示子弹特效
	public void ShowBulletEffect(Vector3 TargetPosition, float LineWidth, float DisplayTime)
	{
		if (m_Line == null)
			return;
		m_Line.enabled = true;
		m_Line.startWidth = LineWidth;
		m_Line.endWidth = LineWidth;
		m_Line.SetPosition(0, m_GameObject.transform.position);
		m_Line.SetPosition(1, TargetPosition);
		m_EffectDisplayTime = DisplayTime;
	}

	//释放
	public void Release()
	{
		if (m_GameObject != null) GameObject.Destroy(m_GameObject);
	}

	//设置武器拥有者
	public void SetOwner(ICharacter character)
	{
		m_WeaponOwner = character;
	}

	public void SetAtkPlusValue(int value)
	{
		m_AtkPlusValue = value;
	}

	//显示枪口特效
	public void ShowShootEffect()
	{
		if (m_Particles != null)
		{
			m_Particles.Stop();
			m_Particles.Play();
		}

		if (m_Light != null)
		{
			m_Line.enabled = true;
		}
	}

	//获取攻击范围
	public float GetAtkRange()
	{
		return m_AtkRange;
	}
	//获取攻击力
	public  int GetAtkValue()
	{
		return m_AtkPlusValue + m_AtkValue;// +m_WeaponOwner.xxxxxxxx
	}

	//播放音效
	public void ShowSoundEffect(string ClipName)
	{
		if (m_Audio == null)
			return;

		//获取音效
		IAssetFactory Factory = PBDFactory.GetAssetFactory();
		AudioClip theClip = Factory.LoadAudioClip(ClipName);
		if (theClip == null)
			return;
		m_Audio.clip = theClip;
		m_Audio.Play();
	}

	//攻击目标
	public void Fire(ICharacter theTarget)
    {
        //显示武器发射/枪口特效
        ShowShootEffect();

        //显示武器子弹特效（子类实现）
        DoShowBulletEffect(theTarget);

        //播放音效（子类实现）
        DoShowSoundEffect();

        //直接命中攻击
        theTarget.UnderAttack(m_WeaponOwner);

    }

    //显示武器子弹特效
    protected abstract void DoShowBulletEffect(ICharacter theTarget);

    //播放音效
    protected abstract void DoShowSoundEffect();
}
