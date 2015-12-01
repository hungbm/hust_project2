using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int hitPoint;
	public int gold;
	public float score;
    public int wave;
    public  static GameObject ChosenItem;
    public static string coin;
    public static string health;
    public static string waveString;
    public static string scoreString;
	// Use this for initialization
	void Start () {
		score = 0;
        coin = gold.ToString();
        health = hitPoint.ToString();
        //waveString = wave.ToString();
        scoreString = score.ToString();
	}

	
	// Update is called once per frame
	void Update () {
		if (hitPoint <= 0) {
			GameObject.Find("Target").GetComponent<Rigidbody>().useGravity=true;
            Debug.Log("Game Over");
		}
        coin = gold.ToString();
        health = hitPoint.ToString();
        scoreString = score.ToString();
	}
    public void SetChosenItem(GameObject obj)
    {
        ChosenItem = obj;
    }

	public void addScore(float score){
		this.score += score;
	}

	public void addGold(int gold){
		this.gold += gold;
	}
}
