using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectiles : MonoBehaviour
{
    public float speed = 10f;
    //public Vector2 velocity = new Vector2(0, 15f);
    public float missileDamage = 12.5f;

    public float lifeTime = 7f;
    public float destroyTime;

    //public Rigidbody2D rb2d;

    private void Start()
    {
        destroyTime = Time.time + lifeTime; //now + 7 seconds
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //normally forward, but this asset is weird and is turned so it is right here
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        //rb2d.MovePosition(Vector2.up * speed * Time.fixedDeltaTime);

        if (Time.time > destroyTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //The Good Stuff:
        //Damagable damagable = collision.gameObject.GetComponentInParent<Damagable>();
        //if (damagable != null && collision.gameObject.tag != "Player") { damagable.Damage(missileDamage); }

        if (collision.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }

        //Debug.LogError("HitSomething");
    }
}
