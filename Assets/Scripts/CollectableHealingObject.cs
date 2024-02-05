using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableHealingObject : MonoBehaviour
{
    public int healAmount = 5;
    // this will be called whenever other objects enter the trigger zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // wrtie your healing process here
        if (collision.tag == "Player") // check if the incoming object is player
        {
            RubyController controller = collision.GetComponent<RubyController>();

            if (controller.currentHP < controller.maxHP)
            {
                print("Player HP is now " + controller.currentHP);
                controller.ChangeHP(healAmount); //heal the player for heal amount
                //controller.HP += healAmount; //  this is wrong
                Destroy(this.gameObject);
            }   // "this" means myself ( the script)
                // "gameObject" means the whole gameObject
        }
    }
}
