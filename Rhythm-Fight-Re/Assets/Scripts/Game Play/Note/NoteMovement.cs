using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
	Vector3 pos;
	Vector3 endPos;

	private void Start()
	{
		pos = transform.position;
		endPos = new Vector3(pos.x + 20f, pos.y, pos.z);
		StartCoroutine(move());
	}


	private IEnumerator move()
	{
		float duration = 2f;
		float ElapsedTime = 0f;
		while(ElapsedTime < duration)
		{
			ElapsedTime += Time.deltaTime;
			float t  = ElapsedTime / duration;
			transform.position = Vector3.Lerp(pos, endPos, t);
			yield return null;
		}
	}
}
