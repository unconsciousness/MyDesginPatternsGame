using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuState : ISceneState {
	public GameObject UITool;//sssss
	public MainMenuState(SceneStateController Controller): base(Controller)
	{
		StateName = "MainMenuState";
	}
	
	//开始
	public override void StateBegin()
	{
		//获取开始按钮"StartGameBtn"
		Button tmpBtn = UITool.GetComponent<Button>();//ssssssssssss
		if (tmpBtn != null) tmpBtn.onClick.AddListener(() => OnStartGameBtnClick(tmpBtn));
	}

	//开始游戏
	private void OnStartGameBtnClick(Button theButton)
	{
		Debug.Log("OnStartBtnClick: " + theButton.gameObject.name);

	}

	
}
