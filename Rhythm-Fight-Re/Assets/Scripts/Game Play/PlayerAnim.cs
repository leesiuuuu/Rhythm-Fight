using UnityEngine;

public class PlayerAnim : PlayerManager
{
	public void PlayAnim(Animator animator, PunchType punchType)
	{
		switch (punchType)
		{
			case PunchType.LPL:
				animator.SetTrigger("LPL"); break;
			case PunchType.LPR:
				animator.SetTrigger("LPR"); break;
			case PunchType.RPL:
				animator.SetTrigger("RPL"); break;
			case PunchType.RPR:
				animator.SetTrigger("RPR"); break;
		}
	}
}
