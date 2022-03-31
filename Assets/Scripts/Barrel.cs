using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    [SerializeField]
    private Transform barrelTip;

    [SerializeField]
    private GameObject bullet;

    private Vector2 lookDirection;
    private float lookAngle;

    // Update is called once per frame
    void Update()
    {
        //calculate lookDirection from barells position
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);
        if(Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        
       //GameObject firedBullet = Instantiate(bullet, barrelTip.position, barrelTip.rotation);
      // firedBullet.GetComponent<Rigidbody2D>().velocity = barrelTip.up * 10f;

        
        Vector3 rot = barrelTip.rotation.eulerAngles;
        rot = new Vector3(rot.x, rot.y, rot.z + 180);
        GameObject firedBullet = Instantiate(bullet, barrelTip.position, Quaternion.Euler(rot));
        firedBullet.GetComponent<Rigidbody2D>().velocity = barrelTip.up * 10f;
        
    }

}
