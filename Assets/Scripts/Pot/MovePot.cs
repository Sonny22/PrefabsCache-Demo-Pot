using UnityEngine;
using System.Collections;

public class MovePot : MonoBehaviour 
{
	public Transform leftTarget;
	public Transform rightTarget;

	private float direction = 1f;
	private Vector3 velocity;
	
	void Update () 
	{
		Vector3 target = direction > 0f ? rightTarget.position : leftTarget.position;
		transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, 1f);

		if (Vector3.Distance(transform.position, leftTarget.position) < 0.1f || Vector3.Distance(transform.position,rightTarget.position) < 0.1f)
			direction *= -1f;
	}
}
