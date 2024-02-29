using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public int healAmount;
    // this will be called whenever other objects enter the trigger zone
    void OnTriggerEnter2D(Collider2D other)
    {
        // wrtie your healing process here
        if (other.tag == "Player") // check if the incoming object is player
        {
            RubyController controller = other.GetComponent<RubyController>();

            if (controller.health < controller.maxHealth)
            {
                print("Player HP is now " + controller.health);
                controller.ChangeHealth(healAmount); //heal the player for heal amount
                //controller.HP += healAmount; //  this is wrong
                Destroy(this.gameObject);
            }   // "this" means myself ( the script)
                // "gameObject" means the whole gameObject
        }
    }
}
