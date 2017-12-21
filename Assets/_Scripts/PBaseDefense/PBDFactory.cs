using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;
//资源生成工厂
public static class PBDFactory
{
	private static IAssetFactory m_assetFactory = null;
	public static bool m_bLoadFromResource;
	public static IAssetFactory GetAssetFactory()
	{
		if (m_assetFactory == null)
		{
			if (m_bLoadFromResource)
				m_assetFactory = new ResourceAssetFactory();
			else
				m_assetFactory = new RemoveAssetFactory();
		}
		return m_assetFactory;
	}
	
}

public interface IAssetFactory
{
	 AudioClip LoadAudioClip(string ClipName);
	

	
}

public class ResourceAssetFactory : IAssetFactory
{
	public AudioClip LoadAudioClip(string ClipName)
	{
		throw new System.NotImplementedException();
	}
}

public class RemoveAssetFactory : IAssetFactory
{
	public AudioClip LoadAudioClip(string ClipName)
	{
		throw new System.NotImplementedException();
	}
}