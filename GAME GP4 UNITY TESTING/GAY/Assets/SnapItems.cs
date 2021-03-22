using UnityEngine;
using System.Collections;

public class SnapItems : MonoBehaviour
{

	Transform player;
	bool snapping = false;
	bool startSnap = false;
	float startTime;
	float duration = 0.5f;
	Vector3 currentPos;
	Vector3 endPos;

	void Start()
	{
		player = GameObject.FindWithTag("Player").transform;
	}

	void Update()
	{
		if (!snapping)
		{
			float dist = Vector3.Distance(transform.position, player.position);
			if (dist < 5)
			{
				snapping = true;
				if (!startSnap)
				{
					startTime = Time.time;
					startSnap = true;
				}
			}
		}
		else
		{
			currentPos = transform.position;
			endPos = player.position;
			transform.position = Vector3.Lerp(currentPos, endPos, (Time.time - startTime) / duration);
		}
	}
}
