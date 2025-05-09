using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PunchType
{
	LPR,
	LPL,
	RPR,
	RPL
}

public class PlayerInput : PlayerManager
{
	private void Start()
	{
		animator = GetComponent<Animator>();
		playerAnim = GetComponent<PlayerAnim>();
	}

	void Update()
    {
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.F))
		{
			if(LPunchCnt == 0)
			{
				playerAnim.PlayAnim(animator, PunchType.LPL);
			}
			else
			{
				playerAnim.PlayAnim(animator, PunchType.LPR);
			}
			LPunchCnt = ++LPunchCnt % 2;
		}
		if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K))
		{
			if (RPunchCnt == 0)
			{
				playerAnim.PlayAnim(animator, PunchType.RPL);
			}
			else
			{
				playerAnim.PlayAnim(animator, PunchType.RPR);
			}
			RPunchCnt = ++RPunchCnt % 2;
		}
    }
}
