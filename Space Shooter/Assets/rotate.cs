using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed;
    private Vector3 fangxiang;
    public Transform player;
    public float speed2;
    // Start is called before the first frame update
    void Start()
    {
        
        //GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * speed;

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Rotate(Vector3.up, 45 * Time.deltaTime, Space.Self);//物体自转代码
        //transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
        //transform.Rotate(new Vector3(0, 1, 0));
        fangxiang = transform.position - player.position;//物体与小球的位置差
        fangxiang.y = 0;//y轴方向上的位置不需要改变，根据实际情况而定
        transform.Translate(-fangxiang * speed2 * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);


    }
    

}
