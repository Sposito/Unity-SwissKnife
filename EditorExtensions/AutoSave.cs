// Simple editor window that autosaves the working scene
// Make sure to have this window opened to be able to execute the auto save.

// Implentation in C# of the UnityScript version presented in the official documentation.
using UnityEditor;
using System;
using UnityEngine;
/// <summary>
/// Editor Window that saves the game in periodics amounts of time
/// </summary>
class AutoSave : EditorWindow {

	double saveTime  = 300d;
	double nextSave  = 0d;

	[MenuItem("Window/AutoSave")]
	static void Init() {
		AutoSave window  = (AutoSave) EditorWindow.GetWindowWithRect( typeof(AutoSave), new Rect (0,0,300,40));
		window.Show();

	}

	 void OnGUI() {
		EditorGUILayout.LabelField("Save Each:", saveTime + " Secs");
		double timeToSave = nextSave - EditorApplication.timeSinceStartup;
		EditorGUILayout.LabelField("Next Save:", Convert.ToInt32(timeToSave) + " Sec");
		this.Repaint();

		if(EditorApplication.timeSinceStartup > nextSave) {
			string[] path  = EditorApplication.currentScene.Split(char.Parse("/"));
			path[path.Length -1] = "AutoSave_" + path[path.Length-1];
			EditorApplication.SaveScene(String.Join("/",path), true);
			Debug.Log("Saved Scene");
			nextSave = EditorApplication.timeSinceStartup + saveTime;
		}
	}
}
