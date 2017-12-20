using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter
{
	protected string m_Name = "";//名称
	protected GameObject m_GameObject = null;//显示的Unity模型
	protected NavMeshAgent m_NavAgent = null;//用于控制角色移动
	protected AudioSource m_Audio = null;//?
	protected string m_IconSpriteName = "";//显示Icon

	protected bool m_bKilled = false;//是否阵亡
	protected bool m_bCheckKilled = false;//是否确定过阵亡事件
	protected float m_RemoveTimer = 1.5f;//阵亡之后多久删除
	protected bool m_bCanRemove = false;//可否被删除
	
	//拥有一把武器
	protected Weapon m_Waepon = null;

	public abstract void Attack(ICharacter theTarget);








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
