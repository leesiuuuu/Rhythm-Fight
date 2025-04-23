using FMODUnity;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[SerializeField] EventReference TestEvent;

	public void SoundPlay()
	{
		RuntimeManager.PlayOneShot(TestEvent);
	}
}
