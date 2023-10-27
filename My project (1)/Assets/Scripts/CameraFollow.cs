using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    void LateUpdate (){
        var pos = transform.position;
        var posPlayer = target.position;
        var repos = offset;
        pos.y = posPlayer.y + repos.y;
        transform.position = pos;
    }
}

