using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CannonBehaviour : MonoBehaviour
{
    [SerializeField]
    FixedJoystick fj;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject meteor;
    [SerializeField]
    float delay;
    float recharge;

    void FixedUpdate()
    {
        
    }
    public void Fire()
    {
        if(Time.time > recharge)
        {
            Instantiate(meteor,firePoint.position,firePoint.rotation);
            recharge = Time.time + delay;
        }
    }
}
