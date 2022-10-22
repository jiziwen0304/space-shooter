using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;
    public bool IsFire;
    public GameObject shoot;
    private float nextFire; //下一次开火的时间
    public float fireRate = 1.0f;
    void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>();
    }
    void OnFire(InputValue value)
    {
        IsFire = true;
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(-moveValue.y, 0.0f, moveValue.x);


        transform.rotation = Quaternion.Euler(0, 90, 45 * moveValue.x);


        GetComponent<Rigidbody>().AddForce(movement * speed * Time.fixedDeltaTime);
        if (IsFire)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(shoot, transform.Find("head").gameObject.transform.position, shoot.gameObject.transform.rotation);
                IsFire = false;

            }

        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -3.3f, 3.3f));
    }
}
