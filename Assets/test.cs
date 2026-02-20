using UnityEngine;


#region test
/*

*/
#endregion

public class test : MonoBehaviour
{
    #region 인스펙터
    [Header("body")]
    [SerializeField] Transform _body;

    [Header("속도")]
    [SerializeField] float _speed;
    #endregion

    #region 내부 변수

    #endregion

    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _body.Translate(Vector3.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _body.Translate(-Vector3.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _body.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _body.Translate(-Vector3.right * _speed * Time.deltaTime);
        }

    }
}
