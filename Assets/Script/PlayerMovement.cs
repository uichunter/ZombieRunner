using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float m_DefaultView;
	public float m_ZoomInView;
	public GameObject m_HeliPrefab;

	private Camera m_ViewCamera;
	private bool m_IsHeliSpwan = false;

		
	// Use this for initialization
	void Start () {
		m_ViewCamera = GetComponentInChildren<Camera>();
	}

	void Update ()
	{
		Zoom();
		Call();
	}

	void Zoom ()
	{
		if (Input.GetButton ("Zoom")) {
			m_ViewCamera.fieldOfView = Mathf.Lerp(m_ViewCamera.fieldOfView,m_ZoomInView,Time.deltaTime*(m_ViewCamera.fieldOfView - m_ZoomInView));
		} else {
			m_ViewCamera.fieldOfView = Mathf.Lerp(m_ViewCamera.fieldOfView,m_DefaultView,Time.deltaTime*(m_DefaultView - m_ViewCamera.fieldOfView));
		}
	}

	void Call ()
	{
		if (Input.GetButton("Heli") && !m_IsHeliSpwan){

			m_IsHeliSpwan = true;

			GameObject HeliInstace = Instantiate(m_HeliPrefab,transform.position,transform.rotation) as GameObject;
			HelicopterMovement HeliMovement = HeliInstace.GetComponent<HelicopterMovement>();
			HeliMovement.CallHeli();
		}
	}
}
