using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmShooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 mousePos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        //transform.position = new Vector3(worldPosition.x, worldPosition.y,transform.position.z);
        LookAt2D(worldPosition);
    }
    void LookAt2D(Vector2 target)
    {
        Vector2 current = transform.position;
        var direction = target - current;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
