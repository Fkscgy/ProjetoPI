using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CannonBehaviour : MonoBehaviour
{
    [SerializeField]
    float velocity;
    [SerializeField]
    FixedJoystick fj;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject meteor;
    [SerializeField]
    float delay;
    float recharge;
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }
    void FixedUpdate()
    {
        float h = fj.Horizontal * velocity;
        float atual = transform.rotation.eulerAngles.z;
        if(atual > 10f && atual < 170f)
        {
            transform.rotation = Quaternion.Euler(0f,0f,Mathf.Clamp(atual,15f,165f));   
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles - new Vector3(0f,0f,h));
        }
    }
    public void Fire()
    {
        if(Time.time > recharge)
        {
            GameObject go = Instantiate(meteor,firePoint.position,firePoint.rotation);
            recharge = Time.time + delay;
        }
    }
}