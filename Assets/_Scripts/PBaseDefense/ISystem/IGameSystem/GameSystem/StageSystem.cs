using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSystem : IGameSystem
{

	public StageSystem(PBaseDefenseGame thePBaseDefenseGame) : base(thePBaseDefenseGame)
	{
		Initialize();
	}

	public override void Initialize()
	{
		//注册游戏事件
		m_PBDGame.RegisterGameEvent();//ENUM_GameEvent.EnemyKilled,new EnemyKilledObserverStageScore(this)
	}

	public override void Update()
	{
		//更新当前的关卡
		//m_NowStageData.Update();
		//是否要切换到下一个关卡
		if (m_PBDGame.GetEnemyCount() == 0)
		{
			//IStageHandler NewStageData = m_NowStageData.CheckStage();
			//是否为新的关卡
			if (true)//m_NowStageData!=NewStageData
			{
				//m_NowStageData=NewStageData;
				NotifyNewStage();
			}
		}

	}
	//通知进入新的关卡
	private void NotifyNewStage()
	{
		//m_PBDGame.ShowGameMsg("新的关卡");
		//m_NowStageLv++;

		//显示
		//m_PBDGame.ShowNowStageLv(m_NowStageLv);

		//通知Soldier升级
		m_PBDGame.UpgateSoldier();

		//事件
		m_PBDGame.NotifyGameEvent();//ENUM_GameEvent.NewStage,null

	}

	//通知关卡更新
	public void LoseHeart()//活力值的意思吧？
	{
		//m_NowHeart--;
		//m_PBDGame.ShowHeart（m_NowHeart);
	}

}
