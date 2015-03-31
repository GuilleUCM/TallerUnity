using UnityEngine;
using System.Collections;

public class SmoothFollow2D : MonoBehaviour {

    //offset from the viewport center to fix damping
    public float m_DampTime = 0.3f;
    public Transform m_Target;
    public float m_XOffset = 0;
    public float m_YOffset = 0;
    private Vector3 m_Velocity = Vector3.zero;

	void Start () {
		if (m_Target==null){
			m_Target = GameObject.FindGameObjectWithTag("Player").transform;
		}
	}

    void Update() {
        if(m_Target) {
            Vector3 point = camera.WorldToViewportPoint(m_Target.position);
            Vector3 delta = m_Target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref m_Velocity, m_DampTime) + new Vector3(m_XOffset,m_YOffset,0);
        }
    }
}
