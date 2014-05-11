using UnityEngine;
using System.Collections;

public class BackupProject : MonoBehaviour 
{
	public string sourceDirectory;
	public string destinationDirectory;
	public bool manualBackup = true;
	//
	public bool autoBackup = false;
	public double backupTime = 0;
	public double nextBackup = 0;
	public int selectedTime = 10;
	//
	public string copyExtension = "*";
	public enum AssetsTypes {
		//Scene,
		//Prefab,
		Shader,
		ComputeShader,
		FBX,
		All
	}
	public AssetsTypes assetsTypes;
	public int selectedSaveAssets = (int)AssetsTypes.All;
}