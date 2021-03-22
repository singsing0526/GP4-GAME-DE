using UnityEngine;
using System.Collections;

public class CollectItems4 : MonoBehaviour
{

	public AudioClip coinSound;

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Coin")
		{
			ScoreCount4.UpdateScore(10);
			Destroy(col.gameObject);
			AudioSource.PlayClipAtPoint(coinSound, transform.position);
		}
	}
}

