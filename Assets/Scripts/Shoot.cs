using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public float speed = 100f; 

	[SerializeField] private float delay = 0.5f;
	[SerializeField] private GameObject bullet;
	GameObject projectile;
	private float lastTime;

	// Update is called once per frame    
	private void Update()
	{
		if (Time.time - lastTime > delay)
		{
			if(Input.GetKey(KeyCode.Space))
				SpawnBombFromPool();
		}
	}
    private void SpawnBombFromPool()
	{
		lastTime = Time.time;
		Vector3 position = transform.position;
		bullet = BasicPool.Instance.GetFromPool();
		bullet.transform.position = position;
		bullet.GetComponent<Rigidbody2D>().velocity = transform.up * speed * Time.deltaTime;
	}


}