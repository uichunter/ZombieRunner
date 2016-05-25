using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Light))]
public class DayCycle : MonoBehaviour {
	public Transform m_SunTransform;
	public float m_TimeScale;
	public float m_DefaultTime;
	public bool m_isSunStartCycle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (m_isSunStartCycle){
			float anglePerFrame = Time.deltaTime / 360 * m_TimeScale;
			transform.RotateAround(transform.position,Vector3.forward,anglePerFrame);
		}
	}
}