using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
	//AI更新=》画面更新=》特效更新=》怪物进场=》攻击玩家=》物理判定=》（玩家操作）=》 LOOP



	//场景状态
	SceneStateController m_SceneStateController = new SceneStateController();

	//游戏功能
	GameFunction m_gameFunction = new GameFunction();
	void Awake()
	{
		//转换场景不会被删除
		DontDestroyOnLoad(gameObject);

		//随机数种子
		UnityEngine.Random.InitState((int)DateTime.Now.Ticks);//用Random.Range(1,100)来调用
	}

	void Start()
	{
		//设置起始的场景
		m_SceneStateController.SetState(new StartState(m_SceneStateController), "");
	}

	void Update()
	{
		m_SceneStateController.StateUpdate();


		//游戏逻辑更新
		m_gameFunction.Update();
	}
}
