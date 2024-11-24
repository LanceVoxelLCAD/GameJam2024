using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooter : MonoBehaviour
{
    //public GameObject player;
    //private Vector2 playerPos;
    public GameObject bossProjectile;
    public Transform bossFiringPoint;
    public float shotDelay = 6f;
    private float nextShotTime = 0f;
    public bool delay = false;
    public float offsetTime = .5f;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 mousePos = Input.mousePosition;
        if (delay)
        {
            nextShotTime += offsetTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //DEBUG
        if (delay)
        {
            if (Time.time > nextShotTime)
            {
                Instantiate(bossProjectile, bossFiringPoint.position, bossFiringPoint.rotation);
                nextShotTime = Time.time + offsetTime + shotDelay;
            }
        }
        else
        {
            if (Time.time > nextShotTime)
            {
                Instantiate(bossProjectile, bossFiringPoint.position, bossFiringPoint.rotation);
                nextShotTime = Time.time + shotDelay;
            }
        }
        

        //player = GameObject.FindGameObjectWithTag("PlayerSkin");
        //Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        //Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        //transform.position = new Vector3(worldPosition.x, worldPosition.y,transform.position.z);
        //playerPos = player.transform.position;

        //LookAt2D(playerPos);
    }
    //void LookAt2D(Vector2 target)
    //{
    //    Vector2 current = transform.position;
    //    var direction = target - current;
    //    var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    //    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    //}
}
