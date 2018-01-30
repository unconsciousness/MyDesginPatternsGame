using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public abstract class ICharacter
{


    protected string m_Name = "";//名称
    protected GameObject m_GameObject = null;//显示的Unity模型
    protected NavMeshAgent m_NavAgent = null;//用于控制角色移动
    protected AudioSource m_Audio = null;//音频
    protected string m_IconSpriteName = "";//显示Icon

    protected bool m_bKilled = false;//是否阵亡
    protected bool m_bCheckKilled = false;//是否确定过阵亡事件
    protected float m_RemoveTimer = 1.5f;//阵亡之后多久删除
    protected bool m_bCanRemove = false;//可否被删除

    protected ICharacterAttr m_Attribute = null;//角色属性



    //设置角色属性
    public virtual void SetCharacterAttr(ICharacterAttr CharacterAttr)
    {
        //设置
        m_Attribute = CharacterAttr;
        m_Attribute.InitAttr();

        //设置移动速度
        m_NavAgent.speed = m_Attribute.GetMoveSpeed();
        //Debug.Log("设置移动速度："+m_NavAgent.speed);


        //名字
        m_Name = m_Attribute.GetAttrName();
    }



    /////////////////////////////////////////////////////////////////////////武器和攻击↓
    //拥有一把武器
    //protected Weapon m_Waepon = null;(Bridge前的实现)
    private IWeapon m_Weapon = null;//private是为了把直接对武器的操作方法在抽象类ICharacter完成，解除和子类的耦合

    //设置使用的武器
    public void SetWeapon(IWeapon Weapon)
    {
        if (m_Weapon != null)
        {
            m_Weapon.Release();
        }
        m_Weapon = Weapon;

        //设置武器拥有者
        m_Weapon.SetOwner(this);

        //设置Unity GameObject 的层级
        //UnityTool.Attach(m_GameObject,m_Weapon.GetGameObject(),Vector3.zero);
    }
    //获取武器
    public IWeapon GetWeapon()
    {
        return m_Weapon;
    }

 //设置额外攻击力（Attack函数在IEnemy的子类中实现时要引用到这个函数）
    //protected void SetWeaponAtkPlusValue(int Value)
    //{
    //    m_Weapon.SetAtkPlusValue(Value);
    //}

    //武器攻击目标（Attack函数在ICharacter的子类实现时要引用到这个函数）
    //protected void WeaponAttackTarget(ICharacter Target)
    //{
    //    m_Weapon.Fire(Target);
    //}

    //计算攻击力
    public int GetAtkValue()
    {
        //武器攻击力+角色属性的加成
        return m_Weapon.GetAtkValue();
    }

    //获取攻击距离
    public float GetAttackRange()
    {
        return m_Weapon.GetAtkRange();
    }

    //攻击目标
    public void Attack(ICharacter theTarget)////后面的注释是改代码之前的注释====由子类去实现自己的攻击函数，调用WeaponAttackTarget(ICharacter Target)来攻击敌人
    {
        //设置额外攻击力
        m_Weapon.SetAtkPlusValue(m_Attribute.GetAtkPlusValue());

        //使用武器攻击目标
        m_Weapon.Fire(theTarget);
    }
    //被攻击
    public abstract void UnderAttack(ICharacter Attacker);
   


    /////////////////////////////////////////////////////////////////////////武器和攻击↑








    //建造者
    public ICharacter() { }
    //设置Unity模型
    public void SetGameObject(GameObject theGameObject)
    {
        m_GameObject = theGameObject;
        m_NavAgent = theGameObject.GetComponent<NavMeshAgent>();
        m_Audio = theGameObject.GetComponent<AudioSource>();
    }

    //获取Unity模型
    public GameObject GetGameObject()
    {
        return m_GameObject;
    }

    //释放
    public void Release()
    {
        if (m_GameObject != null) GameObject.Destroy(m_GameObject);
    }

    //名称
    public string GetName()
    {
        return m_Name;
    }

    //设置Icon名称
    public void SetIconSpriteName(string SpriteName)
    {
        m_IconSpriteName = SpriteName;
    }

    //获取Icon名称
    public string GetIconSpriteName()
    {
        return m_IconSpriteName;
    }

    public Vector3 GetPosition()
    {
        return m_GameObject.transform.position;
    }
}
