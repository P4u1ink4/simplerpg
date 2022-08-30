using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : Collidable
{
    public string message;
    private float cooldown = 6.0f;
    private float lastShout = -4.0f;

    protected override void OnCollide(Collider2D coll)
    {
        if(Time.time - lastShout > cooldown)
        {
            lastShout = Time.time;
            GameManager.instance.ShowText(message,10,Color.black,transform.position + new Vector3(-0.4f,0.4f,0), Vector3.zero, cooldown);
        }
    }
}
