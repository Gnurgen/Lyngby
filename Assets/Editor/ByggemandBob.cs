using UnityEditor;
using System.IO;

public class ByggemandBob{

	static void AndroidBuild(){

		string basePath = "C:/Builds/Android";

		string[] scenes = { "Assets/Scenes/Main.unity" };

		FileUtil.DeleteFileOrDirectory ("C:/Users/Kenned/AppData/LocalUnity/Editor/Editor.log");

		string buildFolder = System.DateTime.Now.ToString ("dd-MM-yy HH.mm.ss");

		Directory.CreateDirectory (basePath + "/" + buildFolder);

		BuildPipeline.BuildPlayer (scenes, basePath + "/" + buildFolder + "/" + "buildfile.apk" , BuildTarget.Android, BuildOptions.None);

		FileUtil.CopyFileOrDirectory ("C:/Users/Kenned/AppData/LocalUnity/Editor/Editor.log", basePath + "/" + buildFolder + "/log.txt");
	}
}