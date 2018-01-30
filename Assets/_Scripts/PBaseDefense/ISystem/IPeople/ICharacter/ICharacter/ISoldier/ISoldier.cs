using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ISoldier : ICharacter
{
    public override void UnderAttack(ICharacter Attacker)
    {
        //计算伤害值
        m_Attribute.CalDmgValue(Attacker);

        

        //是否阵亡
        if (m_Attribute.GetNowHP() <= 0)
        {
            Debug.Log("角色阵亡");
            DoPlayKilledSound();//音效
            DoShowKilledEffect();//特效
            //Killed();//阵亡
        }
    }


    //播放音效
    public abstract void DoPlayKilledSound();

    //显示特效
    public abstract void DoShowKilledEffect();


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

    //攻击目标
    //public override void Attack(ICharacter theTarget)
    //{
    //	//武器攻击
    //	WeaponAttackTarget(theTarget);
    //}

    ////被武器攻击
    //public override void UnderAttack(ICharacter Attacker)
    //{
    //	throw new System.NotImplementedException();
    //}

}
