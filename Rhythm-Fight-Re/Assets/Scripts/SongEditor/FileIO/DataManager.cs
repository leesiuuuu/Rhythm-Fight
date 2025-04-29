using System.IO;
using UnityEngine;
using static EditorEnum;

public class DataManager
{
	public void CreateFileData(string filePath, string name, string composer, bool Easy, bool Normal, bool Hard, bool RealFight)
	{
		string path = filePath + "Info.json";
		FileData InitData = new FileData(name, composer, Easy, Normal, Hard, RealFight);
		
		string jsonInit = JsonUtility.ToJson(InitData, true);

		SaveJsonFile(path, jsonInit);

		EditorManager.Instance.SetFile(InitData);
	}

	private void SaveJsonFile(string filePath, string jsonData)
	{
		File.WriteAllText(filePath, jsonData);
		Debug.Log("파일이 생성되고 저장되었습니다!");
	}
}
[System.Serializable]
public class FileData
{
	public string name;
	public string composer;

	public bool Easy;
	public bool Normal;
	public bool Hard;
	public bool RealFight;

	public double BPM;

	public BGType bgType = BGType.Stadium;

	public FileData(string name, string composer, bool Easy, bool Normal, bool Hard, bool RealFight)
	{
		this.name = name;
		this.composer = composer;
		this.Easy = Easy;
		this.Normal = Normal;
		this.Hard = Hard;
		this.RealFight = RealFight;
		BPM = 100;
	}
}
