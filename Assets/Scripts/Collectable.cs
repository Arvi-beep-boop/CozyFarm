using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    //player walks into collectable
    // add collectable to player
    // delete collectable from the screen

    public CollectableType type;
    public Sprite icon;

    public Rigidbody2D rb2d;

    public void Awake()
    {
        rb2d= GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player)
        {
            player.inventory.Add(this);
            Destroy(this.gameObject);
        }
    }
}
public enum CollectableType
{
    NONE, TOMATO_SEED, CARROT_SEED
}