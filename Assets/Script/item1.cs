﻿using UnityEngine;
using System.Collections;

public class item1 : MonoBehaviour {
    public GameObject model;
    private GameObject[] foundClone;
    public Transform pos;
    public float x, y, z;
    public float a, b, c;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void isClickedItem1()
    {
        foundClone = GameObject.FindGameObjectsWithTag("Clone");
        if (foundClone.Length > 0)
        {
            foreach (GameObject clone in foundClone)
            {
                Destroy(clone);
            }
        }
        //a.transform.position = new Vector3(-1.36f, -2.05f, -5.5f);
        GameObject obj =  Instantiate(model, pos.position, pos.rotation) as GameObject;
        obj.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
        obj.transform.position = new Vector3(-1.36f,-2.05f,-5.5f);
        DetailOfItem.NameOfItem = "Sung 1";
        DetailOfItem.Damage = 3;
        DetailOfItem.Speed = 2;
        DetailOfItem.Range = 3;
        DetailOfItem.Shield = 2;
        DetailOfItem.Level = 1;
        DetailOfItem.RunDamageFinished = false;
        DetailOfItem.RunRangeFinished = false;
        DetailOfItem.RunShieldFinished = false;
        DetailOfItem.RunSpeedFinished = false;
        DetailOfItem.RunLevelFinished = false;
    }
}