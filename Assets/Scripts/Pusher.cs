using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    Vector3 startPosition;

    //移動量プロパティ
    public float amplitude;
    //移動速度プロパティ
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        startPosition=transform.localPosition;   
    }

    // Update is called once per frame
    void Update()
    {
        //変異を計算
        float z=amplitude*Mathf.Sin(Time.time*speed);
        //zを変異させたポジションに再設定
        transform.localPosition=startPosition+new Vector3(0,0,z);        
    }
}
