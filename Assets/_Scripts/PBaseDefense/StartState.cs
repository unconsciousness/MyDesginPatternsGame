using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : ISceneState {
	public StartState(SceneStateController Controller): base(Controller)
	{
		StateName = "StartState";
	}
	
	//开始
	public override void StateBegin()
	{
		//可在此进行游戏数据加载和初始化等
	}

	//更新
	public override void StateUpdate()
	{
		//更换为
		m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuState");
	}
}
