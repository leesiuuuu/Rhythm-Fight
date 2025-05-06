using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
	bool dir = false;
	public void PlayAnim(Animator animator)
	{
		if (!dir) animator.SetTrigger("PunchLeft");
		else animator.SetTrigger("PunchRight");
		dir = !dir;
	}
}
