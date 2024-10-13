using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    public Animation anim;
    public GameObject target;
    public float minDisance;
    bool closed = true;
    int aminPlayCount = 0;

    void Update()
    {
        Vector3 distance = target.transform.position - transform.position;
        if (distance.magnitude <= minDisance)
        {
            if ((closed == true) && (aminPlayCount == 0))
            {
                OpenDoor();
                aminPlayCount++;
                closed = false;
            }
        }
        else
        {
            if (closed == false)
            {
                CloseDoor();
                closed = true;
                aminPlayCount = 0;
            }
        }
    }

    //private IEnumerator AfterShoot()
    //{

    //}

    void CloseDoor()
    {
        anim.Play("door_close");
    }

    void OpenDoor()
    {
        anim.Play("door_open");
    }
}
