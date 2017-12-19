using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBaseDefenseGame
{



	//Singleton模式
	private static PBaseDefenseGame _intance;
	public static PBaseDefenseGame Intance
	{
		get
		{
			if (_intance == null)
			{
				_intance = new PBaseDefenseGame();
			}
			return _intance;
		}
	}
	private PBaseDefenseGame() { }



	//游戏系统

	private GameEventSystem m_GameEventSystem = null;       //游戏事件系统
	private CampSystem m_CampSystem = null;                 //兵营系统
	private StageSystem m_StageSystem = null;               //关卡系统
	private CharacterSystem m_CharacterSystem = null;       //角色管理系统
	private APSystem m_APSystem = null;                     //行动力系统
	private AchievementSystem m_AchievementSystem = null;   //成就系统
															/*
															//界面
															private CampInfoUI m_CampInfoUI = null;					//兵营界面
															private SoldierInfoUI m_SoldierInfoUI = null;			//战士信息界面
															private GameStateInfoUI m_GameStateInfoUI = null;		//游戏状态界面
															private GamePauseUI m_GamePauseUI = null;				//游戏暂停界面



															*/
															//游戏状态
	bool m_bGameOver = false;



	public void Initinal()
	{

		//场景状态控制
		m_bGameOver = false;
		//游戏系统
		GameEventSystem m_GameEventSystem = new GameEventSystem(this);      //游戏事件系统
		CampSystem m_CampSystem = new CampSystem(this);                     //兵营系统
		StageSystem m_StageSystem = new StageSystem(this);                  //关卡系统
		CharacterSystem m_CharacterSystem = new CharacterSystem(this);      //角色管理系统
		APSystem m_APSystem = new APSystem(this);                           //行动力系统
		AchievementSystem m_AchievementSystem = new AchievementSystem(this);//成就系统
																			/*
																			//界面
																			m_CampInfoUI = new CampInfoUI(this);								//兵营信息
																			m_SoldierInfoUI = new SoldierInfoUI(this);							//Soldier信息
																			m_GameStateInfoUI = new GameStateInfoUI(this);						//游戏数据
																			m_GamePauseUI = new GamePauseUI(this);								//游戏暂停
																			//注入到其他系统 
																			EnemyAI.SetStageSystem(m_StageSystem);


																			*/
	}

	public void Update()
	{
		/*
		//游戏系统更新
		m_GameEventSystem.Update();
		m_CampSystem.Update();
		m_StageSystem.Update();
		m_CharacterSystem.Update();
		m_APSystem.Update();
		m_AchievementSystem.Update();
		*/
	}

	//游戏状态
	public bool ThisGameIsOver()
	{
		return m_bGameOver;
	}

	//当前敌人数量
	public int GetEnemyCount()
	{
		//if(m_CharacterSystem!=null)
		//	return m_CharacterSystem.GetEnemyCount();
		return 0;
	}

	//获取各单位数量
	//public int GetUnitCount(ENUM_Soldier emSoldier)
	//{
	//	return m_CharacterSystem.GetUnitCount(emSoldier);
	//}
	//public int GetUnitCount(ENUM_Enemy emEnemy)
	//{
	//	return m_CharacterSystem.GetUnitCount(emEnemy);
	//}

	//升级Soldier
	public void UpgateSoldier()
	{
		if (m_CharacterSystem != null)
			Debug.Log("士兵升级！");//m_CharacterSystem.UpgateSoldier();
	}

	//增加Soldier
	public void AddSoldier()//ISoldier theSoldier
	{
		if (m_CharacterSystem != null)
		{
			//m_CharacterSystem.AddSoldier(the Soldier);
		}
	}

	//删除Soldier
	public void RemoveSoldier()//Isoldier theSoldier
	{
		if (m_CharacterSystem != null)
		{
			//m_CharacterSystem.RemoveSoldier(theSoldier);
		}
	}

	//增加Enemy
	public void AddEnemy()//IEnemy theEnemy
	{
		if (m_CharacterSystem != null)
		{
			//m_CharacterSystem.AddEnemy(theEnemy);
		}
	}

	//删除Enemy
	public void RemoveEnemy()//IEnemy theEnemy
	{
		if (m_CharacterSystem != null)
		{
			//m_CharacterSystem.RemoveEnemy(theEnemy);
		}
	}

	//显示兵营信息
	public void ShowCampInfo()//ICamp Camp
	{
		//m_CampInfoUI.ShowInfo(Camp);
		//m_SoldierInfoUI.Hide();
	}
	//显示Soldier信息
	public void ShowSoldierInfo()//ISoldier Soldier
	{
		//m_SoldierInfoUI.ShowInfo(Soldier);
		//m_CampInfoUI.Hide();
	}
	//注册游戏事件
	public void RegisterGameEvent()//ENUM_GameEvent emGameEvent,IGameEventObserver Observer
	{
		//m_GameEventSystem.RegisterObserver(emGameEvent,Observer);
	}
	//通知游戏事件
	public void NotifyGameEvent()//ENUM_GameEvent emGameEvent,System.Object Param
	{
		//m_GameEventSystem.NotifySubject(emGameEvent, Param);
	}
	//玩家输入
	public void InputProcess()
	{
		//Mouse 左键
		if (!Input.GetMouseButtonUp(0))
		{
			return;//如果左键处于按下状态，不进行任何操作
		}

		//由摄像机产生一条射线
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit[] hits = Physics.RaycastAll(ray);

		//遍历每一个被Hit到的GameObject

	}
	//
	//

	//
}
