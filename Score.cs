using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Score : MonoBehaviour{
    public GameManager GameManager;
    public int num;
    public int r;
    void Start()
    {

    }
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject/*(<-���ŏ���������)�����Ɠ����{�[���ƏՓ˂���*/)
        {
            Destroy(this.gameObject);
            /*���̔ԍ����{�[���𒆊ԍ��W�ɐ�������*/
        }
    }
}