#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MusicEditorFileImporter : MonoBehaviour
{
	public InputField ip;
	public Toggle[] levels;
	[MenuItem("Tools/Import Music Files")]
	static void ImportFiles()
	{
		// 1. 음원 파일 선택
		string audioPath = EditorUtility.OpenFilePanel("Select Audio File", "", "mp3,wav,ogg");
		if (string.IsNullOrEmpty(audioPath)) return;

		// 2. 앨범 이미지 선택
		string imagePath = EditorUtility.OpenFilePanel("Select Album Image", "", "png,jpg");
		if (string.IsNullOrEmpty(imagePath)) return;

		// 3. 뮤직비디오 파일 선택
		string videoPath = EditorUtility.OpenFilePanel("Select Music Video", "", "mp4,avi");
		if (string.IsNullOrEmpty(videoPath)) return;

		// 4. 저장할 폴더 경로 설정 (Assets 내부에 MusicData 폴더 생성 예정)
		string targetFolder = Application.dataPath + "/Resources/MusicData/";

		// 폴더 없으면 만들기
		if (!Directory.Exists(targetFolder))
		{
			Directory.CreateDirectory(targetFolder);
		}

		// 5. 파일 복사
		File.Copy(audioPath, targetFolder + Path.GetFileName(audioPath), true);
		File.Copy(imagePath, targetFolder + Path.GetFileName(imagePath), true);
		File.Copy(videoPath, targetFolder + Path.GetFileName(videoPath), true);

		// 6. 에셋 데이터 갱신
		AssetDatabase.Refresh();

		Debug.Log("파일 복사 완료!");
	}
#endif
	public void NewProject()
	{
		if (ip.text == "") return;

		string baseName = ip.text; //이름 저장
		string targetFolder = Application.dataPath + $"/Resources/{baseName}/";

		//만약 파일이 존재하면 로그 출력
		if (Directory.Exists(targetFolder))
		{
			Debug.LogWarning($"폴더가 이미 존재합니다!");
			return;
		}

		// 최종 폴더 생성
		Directory.CreateDirectory(targetFolder);
		AssetDatabase.Refresh();

		Debug.Log($"폴더 생성 완료: {targetFolder}");
	}
}
