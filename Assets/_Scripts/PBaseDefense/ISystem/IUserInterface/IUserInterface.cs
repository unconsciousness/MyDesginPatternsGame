using UnityEngine;
using UnityEditor;

public abstract class IUserInterface
{
	protected PBaseDefenseGame m_PBDGame = null;
	protected GameObject m_RootUI = null;//各UI有各UI的根UI节点
	private bool m_bActive = true;
	public IUserInterface(PBaseDefenseGame PBDGame)
	{
		m_PBDGame = PBDGame;
	}

	public bool IsVisible()
	{
		return m_bActive;
	}

	//显示
	public virtual void Show() {
		m_RootUI.SetActive(true);
		m_bActive = true;
	}

	//隐藏
	public virtual void Hide() {
		m_RootUI.SetActive(false);
		m_bActive = false;
	}

	public virtual void Initialize() { }
	public virtual void Release() { }
	public virtual void Update() { }
}