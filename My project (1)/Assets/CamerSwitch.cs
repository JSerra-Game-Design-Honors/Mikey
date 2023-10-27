using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cam_1;
    public GameObject Cam_2;
    public int Manager;
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        var posPlayer = target.position;
        if(posPlayer.y > 41)
        {
            Manager = 1;
            Cam_1.SetActive(false);
            Cam_2.SetActive(true);
        } else
        {
            Cam_1.SetActive(true);
            Cam_2.SetActive(false);
        }
    }
    public void ManageCamera()
    {
        if(Manager == 0)
        {
            Camera_2();
            Manager = 1;
        }
        else
        {
            Camera_1();
            Manager = 0;
        }
    }

    void Camera_1()
    {
        Cam_1.SetActive(true);
        Cam_2.SetActive(false);
    }
    void Camera_2()
    {
        Cam_1.SetActive(false);
        Cam_2.SetActive(true);
    }
}
