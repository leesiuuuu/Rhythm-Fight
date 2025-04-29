using UnityEngine;
using System.IO;
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
		string path = Application.persistentDataPath + $"/{songName.text}-{composer.text}";

		if (!isSongExist(path))
		{
			Directory.CreateDirectory(path);
			Debug.Log("폴더가 생성되었습니다!");
			//초기 데이터 파일 생성해주는 코드 삽입
			DataManager.CreateFileData(path+"/", songName.text, composer.text, easy.isOn, normal.isOn, hard.isOn, realFight.isOn);
			#if UNITY_EDITOR
				// 4. 에디터에서 경로를 로그로 출력
				Debug.Log($"JSON 파일 저장 위치: {path}");
				UnityEditor.EditorUtility.RevealInFinder(path); // Finder/Explorer에서 열기
			#endif
		}
		else
		{
			//파일 존재 로그 출력
			Debug.LogWarning("파일이 이미 존재합니다!");
			return;
		}
	}
	
	private bool isSongExist(string path)
	{
		return Directory.Exists(path);
	}
}
