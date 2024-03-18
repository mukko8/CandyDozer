using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Vector3 vec=Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CubeRotate());
    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(vec);        
    }
    /*
    戻り値の型はIEnumerator
    最低一回はyield returnの記述が必要
    複数yeild returnの記述可能
    yeild returの後ろでnew WaitForSeconds(秒数)
    するとその時間処理を止めることができる
    通信をする際にもよく利用される
    StartCoroutineで起動
    */
    IEnumerator CubeRotate(){
        yield return new WaitForSeconds(1f);
        vec.x=1.0f;
        yield return new WaitForSeconds(2f);
        vec.x=0f;
        vec.y=1.0f;
        yield return new WaitForSeconds(2f);
        vec.y=0f;
        vec.z=1.0f;
    }
}
