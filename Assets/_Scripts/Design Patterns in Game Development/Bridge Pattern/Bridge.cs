using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge  {

	


}

//抽象类
public abstract class ISharp
{
	protected RenderEngine m_RenderEngine = null;
	public void SetRenderEngine(RenderEngine renderEngine)
	{
		m_RenderEngine = renderEngine;
	}
	public abstract void Draw();
}
public class Sphere : ISharp
{
	public override void Draw()
	{
		string Msg = "Sphere";
		Debug.Log("Hoooo!" + Msg);
		m_RenderEngine.Render(Msg);
	}
}
public class Cube : ISharp
{
	public override void Draw()
	{
		string Msg = "Cube";
		Debug.Log("Hoooo!" + Msg);
		m_RenderEngine.Render(Msg);
	}
}



//抽象类
public abstract class RenderEngine
{
	public abstract void Render(string Msg);
}
//实现类
public class DirectX : RenderEngine
{
	public override void Render(string Msg)
	{
		Debug.Log("I am DirectX!   Msg :   "+Msg);
	}
}
//实现类
public class OpenGL : RenderEngine
{
	public override void Render(string Msg)
	{
		Debug.Log("I am OpenGL!   Msg :   " + Msg);
	}
}