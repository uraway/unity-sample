using System.Linq;
using System.IO;
using System.Collections.Generic;
using UnityEditor;

public static class BuildHelper
{
	public static void StandaloneWindows64()
	{
		BuildPipeline.BuildPlayer(GetScenes(), getLocationPath(), BuildTarget.StandaloneWindows64, BuildOptions.None);
	}

	public static void StandaloneLinux64()
	{
		BuildPipeline.BuildPlayer(GetScenes(), getLocationPath(), BuildTarget.StandaloneLinuxUniversal, BuildOptions.None);
	}

	public static void StandaloneOSX()
	{
		BuildPipeline.BuildPlayer(GetScenes(), getLocationPath(), BuildTarget.StandaloneOSX, BuildOptions.None);
	}

	private static string[] GetScenes()
	{
		return EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
	}

    private static string getLocationPath()
    {
        var buildLocation = "./Builds/";
        var projectName = "UnitySample";
        return buildLocation + projectName;
    }
}
