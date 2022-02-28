using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAfterDelay : MonoBehaviour
{
    public float time;
    float timer;
    public SphereCollider obj;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            obj.enabled = (true);
        }
    }


    public void Activate()
    {
        timer = time;
    }
}
