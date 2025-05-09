using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteData
{
	/// <summary>
	/// 0 = Up
	/// 1 = Left
	/// 2 = Right
	/// </summary>
	public int pos;

	public int time;
	
	/// <summary>
	/// 0 = 일반 노트
	/// 1 = 동타 노트
	/// 2 = 연타 노트
	/// </summary>
	public int type;

	//연타 노트 사용 시 필요한 변수
	public int hitCount;

	public void TransmitData(NoteData data)
	{
		pos = data.pos;
		time = data.time;
		type = data.type;
		hitCount = data.hitCount;
	}
}
