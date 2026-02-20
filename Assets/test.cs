using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#region test
/*

*/
#endregion

public class test : MonoBehaviour
{
    #region 인스펙터

    #endregion

    #region 내부 변수
    public float speed = 5f;
    #endregion

    void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0, z);

        transform.Translate(move * speed * Time.deltaTime);
    }
}
