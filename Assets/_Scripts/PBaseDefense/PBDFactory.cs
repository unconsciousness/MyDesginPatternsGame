﻿using System.Collections;
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

}

public class ResourceAssetFactory : IAssetFactory
{

}

public class RemoveAssetFactory : IAssetFactory
{
	
}