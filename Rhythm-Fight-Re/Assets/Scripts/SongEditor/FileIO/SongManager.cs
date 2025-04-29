using UnityEngine;
using System.IO;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class SongManager : MonoBehaviour
{
	public Toggle easy;
	public Toggle normal;
	public Toggle hard;
	public Toggle realFight;

	public TMP_InputField songName;
	public TMP_InputField composer;

	public DataManager DataManager = new DataManager();

	public void CreateSongFile()
	{
		string path = Application.dataPath + $"/Resources/{songName.text}-{composer.text}";

		if (!isSongExist(path))
		{
			Directory.CreateDirectory(path);
			AssetDatabase.Refresh();
			Debug.Log("폴더가 생성되었습니다!");
			//초기 데이터 파일 생성해주는 코드 삽입
			DataManager.CreateFileData(path+"/", songName.text, composer.text, easy.isOn, normal.isOn, hard.isOn, realFight.isOn);
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
