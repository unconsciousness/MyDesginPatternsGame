using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : ISceneState
{
	public BattleState(SceneStateController Controller) : base(Controller)
	{
		StateName = "BattleState";
	}

	//开始
	public override void StateBegin()
	{
		//PBaseDefenseGame.Instance.Initinal();
		Debug.Log(" Game ! Begin !");
	}

	//结束
	public override void StateEnd()
	{
		//PBaseDefenseGame.Instance.Release();
	}

	//更新
	public override void StateUpdate()
	{
		//输入
		InputProcess();

		//游戏逻辑
		//PBaseDefenseGame.Instance.Update();

		//Render由Unity负责 　　　？？？没看懂

		//游戏是否结束
		//if(//PBaseDefenseGame.Instance.ThisGameIsOver())
		//    m_Controller.SetState(new MainMenuState(m_Controller),"MainMenuScene");		
	}

	private void InputProcess() {
		//玩家输入判断程序代码……

	}
}
