using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
	[SerializeField] GameObject player;
	float timer;


	public void SpawnEnemy() 
	{
		Vector3 position = GenerateRandomePosition();

		position += player.transform.position;

		GameObject newEnemy = Instantiate(enemy);
		newEnemy.transform.position = position;
		newEnemy.GetComponent<Enemy>().SetTarget(player);
		newEnemy.transform.parent = transform;
	}

	private Vector3 GenerateRandomePosition() 
	{
		Vector3 position = new Vector3();

		float f = UnityEngine.Random.value > 0.5f ? -1f : 1f;
		if (UnityEngine.Random.value > 0.5f)
		{
			position.x = UnityEngine.Random.Range(-spawnArea.x, spawnArea.x);
			position.y = spawnArea.y * f;

		}
		else
		{
			position.y = UnityEngine.Random.Range(-spawnArea.y, spawnArea.y);
			position.x = spawnArea.x * f;
		}

		position.z = 0;
		
		return position;
	}
}
