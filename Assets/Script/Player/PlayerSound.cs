using UnityEngine;
using System.Collections;

public class PlayerSound : MonoBehaviour {
public AudioSource m_PlyerAudioSource;
public AudioClip[] m_PlayerLineClips;
public float m_PlayerLines01Time;
public bool[] m_IsLinesPlayed;

	// Use this for initialization
	void Start () {
		for (int i =0;i < m_IsLinesPlayed.Length; i++){// Reset the m_IsLinePlayed list;
			m_IsLinesPlayed[i] = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Talk();
	}

	void Talk ()
	{
		if (Time.timeSinceLevelLoad > m_PlayerLines01Time && !m_IsLinesPlayed[0]){
			m_PlyerAudioSource.clip = m_PlayerLineClips[0];
			m_PlyerAudioSource.Play();
			m_IsLinesPlayed[0] = true;
			print("What the hell is going here.'");
		}
	}
}
