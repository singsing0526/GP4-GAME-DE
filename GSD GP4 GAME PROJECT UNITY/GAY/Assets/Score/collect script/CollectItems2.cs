using UnityEngine;
using System.Collections;

public class CollectItems2 : MonoBehaviour
{

	public AudioClip coinSound;

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Coin")
		{
			ScoreCount1.UpdateScore(10);
			Destroy(col.gameObject);
			AudioSource.PlayClipAtPoint(coinSound, transform.position);
		}
	}
}
