using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;

[Serializable]
public class PlayerManager  {
	public Transform[] m_SpwanPointList;
	[HideInInspector] public GameObject m_Instance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Transform GetSpwanPoint(){
		int randomResult = Random.Range(1,m_SpwanPointList.Length);
		return m_SpwanPointList[randomResult].transform;
	}

	public void Setup(){
		
	}
}
