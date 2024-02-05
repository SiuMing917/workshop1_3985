using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // public // this shows in the inspector of Unity 
    // private protected // these dont show

    private int HP;      // current hp that the player has

    // same as the below one
    public int currentHP { get => HP; } 
    //public int currentHP()
    //{
    //    return HP;
    //}

    public int maxHP;   // the maximum hp that the player has

    [Range(0, 100f)]
    public float movementSpeed = 1;
    public Rigidbody2D rb;
    private float hoz;
    private float ver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hoz = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeHP(-5); //damaging player
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            ChangeHP(5); // healing player
        }

    }
    private void FixedUpdate()
    {
        Vector2 positionToMove = new Vector2(hoz, ver) * movementSpeed * Time.fixedDeltaTime;
        Vector2 newPos = (Vector2)transform.position + positionToMove;
        rb.MovePosition(newPos);
    }
    /// <summary>
    /// Value should be given be the enemy
    /// </summary>
    public void ChangeHP(int value) // for the enemy to call to deduct the player hp
    {
        HP += value;

        //if (HP > maxHP)
        //{
        //    HP = maxHP;
        //}
        //if (HP < 0)
        //{
        //    HP = 0;
        //}

        // same as the above
        HP = Mathf.Clamp(HP, 0, maxHP);

        Debug.Log("player hp is now " + HP);
    }

}
