using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 10f;

    void Start(){

        Debug.Log("começou o jogo");


    }

    void Update(){
        if (Input.GetButtonDown("Fire1")){
          GameObject createdbullet = Instantiate(bullet);
            createdbullet.transform.position = transform.position;

            Rigidbody bullet_rig = createdbullet.GetComponent<Rigidbody>();
            Camera cam = GetComponentInChildren<Camera>();

            bullet_rig.velocity = cam.transform.rotation * Vector3.forward * speed;
        }
    }
}
