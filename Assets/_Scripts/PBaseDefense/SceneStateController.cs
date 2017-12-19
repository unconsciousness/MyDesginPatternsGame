using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
	private ISceneState m_State;
	private bool m_bRunBegin = false;
	public SceneStateController() { }
	private string SceneName;
	private AsyncOperation A = null;
	//设置状态
	public void SetState(ISceneState theSceneState, string LoadSceneName)
	{
		//Debug.Log("SetState; "+State.ToString());
		m_bRunBegin = false;

		//载入场景
		LoadScene(LoadSceneName);

		//通知前一个State结束
		if (m_State != null) m_State.StateEnd();

		m_State = theSceneState;
	}


	//载入场景
	private void LoadScene(string LoadSceneName)
	{
		if (LoadSceneName == null || LoadSceneName.Length == 0) return;
		A = SceneManager.LoadSceneAsync(LoadSceneName);
	}

	//更新
	public void StateUpdate()
	{
		//加载中就直接跳出
		if (A != null)
		{
			if (A.isDone && A.progress < 0.8f)
			{
				return;
			}
		}
		
	

		//通知新的State开始
		if (m_State != null && m_bRunBegin == false)
		{
			m_State.StateBegin();
			m_bRunBegin = true;
		}

		if (m_State != null)
		{
			m_State.StateUpdate();
		}


	}
}
