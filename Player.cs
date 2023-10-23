using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Player : MonoBehaviour
{
    /*色で次を示す*/
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
        }           //左キーで左に操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 4)
            {
                this.transform.position += Vector3.right * spead * Time.deltaTime;
            }

        }           //右キーで右に操作
        if (Input.GetKey(KeyCode.DownArrow/*ボールをリリースするキー*/)){
            GenerateScore();    //ボールを生成
        }           //(未決定)キーでボールをリリース,リリース後次のボールをランダムに生成
    }
    public void GenerateScore()
    {
        Instantiate(Score,this.transform);    //objectを生成
    }
}