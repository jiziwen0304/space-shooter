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
        //this.transform.Rotate(Vector3.up, 45 * Time.deltaTime, Space.Self);//������ת����
        //transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
        //transform.Rotate(new Vector3(0, 1, 0));
        fangxiang = transform.position - player.position;//������С���λ�ò�
        fangxiang.y = 0;//y�᷽���ϵ�λ�ò���Ҫ�ı䣬����ʵ���������
        transform.Translate(-fangxiang * speed2 * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);


    }
    

}
