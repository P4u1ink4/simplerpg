using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectable
{
    public int goldAmount = 5;

    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            gameObject.SetActive(false);
            GameManager.instance.gold += goldAmount;
            GameManager.instance.ShowText("+" + goldAmount + "gold!",25,Color.black, transform.position, Vector3.up * 25, 1.0f);
        }
    }    
}
