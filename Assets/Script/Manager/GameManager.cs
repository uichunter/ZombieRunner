using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour {
	public PlayerManager m_Player;
	public GameObject m_PlayerPrefab;
    public Camera m_CameraEditor;


	// Use this for initialization
	void Start () {
		m_CameraEditor.gameObject.SetActive(false);// TODO: Delete the sentense.
		SpwanPlayer();
	}
	
	private void SpwanPlayer ()
	{
		m_Player.m_Instance = Instantiate(m_PlayerPrefab, m_Player.GetSpwanPoint().position,m_Player.GetSpwanPoint().rotation) as GameObject;
		m_Player.Setup();
	}
}
