using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateInfoUI : IUserInterface
{




	public GameStateInfoUI(PBaseDefenseGame pBaseDefenseGame) : base(pBaseDefenseGame)
	{


	}

	//定时更新
	public override void Update()
	{
		//显示双方数量GUI
		//m_SoldierCountText.text = string.Format("我方单位数：{0}",m_PBDGame.GetUnitCount(ENUM_Soldier.Null));
		//m_EnemyCountText.text = string.Format("敌方单位数：{0}",m_PBDGame.GetEnemyCount(ENUM_Enemy.Null));




	}

	//Continue--结束游戏时的继续按钮，回到主菜单
	public void OnContinueBtnClick()
	{
		Time.timeScale = 1;
		//换回开始的State
		//m_PBDGame.ChangeToMainMenu();
	}

	//Pause
	private void OnPauseBtnClick()
	{
		//显示暂停
		//m_PBDGame.GamePause();
	}
}
