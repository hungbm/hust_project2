using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public GameObject[] enemy;
	public float interval=3;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnCon", interval, interval);
	}

	void spawnCon(){
		int i=Random.Range (0, enemy.Length);
        if (enemy[i].GetComponent<FlyingEnemy>())
            Instantiate(enemy[i], new Vector3(transform.position.x, 20, transform.position.z), new Quaternion(0,180,0,0));
        else
            Instantiate(enemy[i], new Vector3(transform.position.x, transform.position.y, transform.position.z - 5f),new  Quaternion(0,180,0,0));
		}
	// Update is called once per frame
	void Update () {
		//transform.Rotate (0,50*Time.deltaTime,0); //rotates 50 degrees per second around z axis
	}
}
