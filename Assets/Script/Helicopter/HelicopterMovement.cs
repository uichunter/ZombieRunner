using UnityEngine;
using System.Collections;

public class HelicopterMovement : MonoBehaviour {

	public AudioClip m_HelicopterCall;
	public AudioClip m_HelicopterReply;
    public AudioSource m_HelicopterAudioSource;
    public float m_HelicopterCallDelay;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CallHeli ()
	{
		m_HelicopterAudioSource.clip = m_HelicopterCall;
		m_HelicopterAudioSource.Play();

		Invoke("HeliReply",m_HelicopterCall.length + m_HelicopterCallDelay);
	}

	public void HeliReply ()
	{
		m_HelicopterAudioSource.clip = m_HelicopterReply;
		m_HelicopterAudioSource.Play();
	}

}
