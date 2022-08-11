using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class AssetBundlePackage
{
    [MenuItem("常用工具/打包AssetBundle")]
    static void BuildAllAssetBundles()
    {
        string folder = "AssetBundle";
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        BuildPipeline.BuildAssetBundles("AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneOSX);
    }
}
