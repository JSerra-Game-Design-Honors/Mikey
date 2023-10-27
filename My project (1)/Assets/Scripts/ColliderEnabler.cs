using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderEnabled : MonoBehaviour
{
    public GameObject obj;
    public BoxCollider m_Collider;
    public Transform target;
    public GameObject obj2;

    void Start()
    {
        m_Collider = obj.transform.gameObject.GetComponent<BoxCollider>();
    }

    void Update()
    {
        var posPlayer = target.position;
        var sizeCollide = m_Collider.size;
        var centerCollide = m_Collider.center;
        if (posPlayer.y > 42)
        {
            if (sizeCollide.z < 1)
            {
                m_Collider.size = new Vector3(1, 1, 1);
                
            }
        }
    }
}
