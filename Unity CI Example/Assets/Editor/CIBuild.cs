﻿using UnityEditor;
using System;
using UnityEngine;
using System.IO;

public class CIBuild
{
    public static string[] scenes =
    {
            "Assets/Example.unity"
    };
    public static void Windows()
    {
        var path = Application.dataPath;
        path = Path.GetDirectoryName(path);
        path += "/Builds/UnityCIExample.exe";
        string res = BuildPipeline.BuildPlayer(scenes, path, BuildTarget.StandaloneWindows, BuildOptions.Development);
        if (res.Length > 0)
            throw new Exception(res);
    }
}