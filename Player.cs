using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Player : MonoBehaviour
{
    /*�F�Ŏ�������*/
    public float spead = 1.0f;
    public GameObject Score;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -4)
            {
                this.transform.position += Vector3.left * spead * Time.deltaTime;
            }
        }           //���L�[�ō��ɑ���
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 4)
            {
                this.transform.position += Vector3.right * spead * Time.deltaTime;
            }

        }           //�E�L�[�ŉE�ɑ���
        if (Input.GetKey(KeyCode.DownArrow/*�{�[���������[�X����L�[*/)){
            GenerateScore();    //�{�[���𐶐�
        }           //(������)�L�[�Ń{�[���������[�X,�����[�X�㎟�̃{�[���������_���ɐ���
    }
    public void GenerateScore()
    {
        Instantiate(Score,this.transform);    //object�𐶐�
    }
}