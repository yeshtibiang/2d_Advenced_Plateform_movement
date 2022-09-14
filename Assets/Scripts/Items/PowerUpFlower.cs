using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFlower : Collectable
{
    public int itemID = 1;
    
    // on va override la classe OnCollect
    override protected void OnCollect(GameObject target)
    {
        // equipbehaviour du target
        var equipBehaviour = target.GetComponent<Equip>();
        if (equipBehaviour != null)
        {
            Debug.Log("item quipped " + itemID);
            equipBehaviour.currentItem = itemID;
        }
    }
    
}
