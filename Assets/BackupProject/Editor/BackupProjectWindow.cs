using UnityEngine;
using System.Collections;
using UnityEditor;

public class BackupProjectWindow : EditorWindow
{
	BackupProject backupScript;
	static BackupProjectWindow settingWindow;

	[MenuItem("Window/Backup Project")]
	static void Init()
	{
		settingWindow = (BackupProjectWindow)EditorWindow.GetWindow(typeof(BackupProjectWindow));
		settingWindow.title = "Backup Project";
	}

	void OnEnable()
	{
		if(backupScript == null)
		backupScript = (BackupProject)FindObjectOfType(typeof(BackupProject));
	}

	void OnGUI()
	{
		backupScript.contentColor = EditorGUILayout.ColorField("Text color", backupScript.contentColor);
		backupScript.backgroundColor = EditorGUILayout.ColorField("Background color", backupScript.backgroundColor);
		EditorGUILayout.Space();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		if(GUILayout.Button("Apply",GUILayout.MaxWidth(100),GUILayout.MaxHeight(30)))
		{
			EditorApplication.SaveScene();
			settingWindow.Close();
		}
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

	}

}
