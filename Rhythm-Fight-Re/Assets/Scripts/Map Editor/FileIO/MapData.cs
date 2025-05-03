using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Video;

[System.Serializable]
public class MapData
{
	public string title;

	public string artistName;
	public string designerName;

	public AudioClip bgm;
	public Sprite album;
	public VideoClip mv;

	public float bpm;
	public SavedNoteData[] notes;

	public void Sort()
	{
		List<SavedNoteData> list = notes.ToList();
		list.Sort((a, b) => (int)Mathf.Sign(a.Beat - b.Beat));
		notes = list.ToArray();
	}
}
[System.Serializable]
public abstract class SavedNoteData
{
	public int _beat = 0;
	public float Beat
	{
		get
		{
			return _beat + ((float)indexInBeat / ((float)standardNoteValue / 4f));
		}
		set
		{
			_beat = (int)value;
		}
	}

	public int standardNoteValue = 1;
	public int indexInBeat = 0;

	public abstract string serializedDataTitleName { get; }
	public abstract float totalScore { get; }

	//게임 플레이 노트 생성
	//멥 에디터 노트 생성
}
