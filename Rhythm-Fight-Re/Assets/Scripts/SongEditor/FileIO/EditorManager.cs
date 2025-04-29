using System.IO;
using UnityEngine;
using UnityEngine.Windows;

public class EditorManager : MonoBehaviour
{
	private static EditorManager instance;
	public static EditorManager Instance
	{
		get
		{
			if(instance == null) instance = new EditorManager();
			return instance;
		}
	}

	public FileData SongData;

	private void Awake()
	{
		if(instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
	public void SetFile(FileData initFile)
	{
		string path = Application.persistentDataPath + $"/{initFile.name}-{initFile.composer}/";
		string filePath = path + "Info.json";

		if (System.IO.File.Exists(filePath))
		{
			string jsonData = System.IO.File.ReadAllText(filePath);
			SongData = JsonUtility.FromJson<FileData>(jsonData);
			Debug.Log("현재 곡 : " + SongData.name);
		}
		else
		{
			Debug.LogWarning("파일이 이미 존재합니다!");
			return;
		}
	}
	
}
