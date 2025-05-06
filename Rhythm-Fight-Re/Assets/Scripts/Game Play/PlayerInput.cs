using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Animator animator;

	private PlayerAnim playerAnim;
	private void Start()
	{
		animator = GetComponent<Animator>();
		playerAnim = GetComponent<PlayerAnim>();
	}

	void Update()
    {
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.F)) playerAnim.PlayAnim(animator);
    }
}
