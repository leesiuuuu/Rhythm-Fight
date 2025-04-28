using UnityEngine;
using System.IO;
using UnityEditor;

public class SongManager : MonoBehaviour
{
	public DataManager DataManager = new DataManager();
	public void CreateSongFile(string name, string composer)
	{
		string path = Application.dataPath + $"/Resources/{name}-{composer}";

		if (!isSongExist(path))
		{
			Directory.CreateDirectory(path);
			Debug.Log("폴더가 생성되었습니다!");
			//초기 데이터 파일 생성해주는 코드 삽입
			//DataManager.CreateFileData();
		}
		else
		{
			//파일 존재 로그 출력
			Debug.LogWarning("파일이 이미 존재합니다!");
			return;
		}
		AssetDatabase.Refresh();
	}
	private bool isSongExist(string path)
	{
		return Directory.Exists(path);
	}
}
