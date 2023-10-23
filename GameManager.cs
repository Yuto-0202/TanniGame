using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public Score[] scores;            //スコア全体を管理
    void Start()
    {

    }
    void Update()
    {
        if (ScoreOver())
        {
            //ゲームオーバー
        }
    }
    private bool ScoreOver()
    {
        foreach (Score s in scores)
        {
            if (s.transform.position.z > 10)
            {
                return true;
            }           //ボールがあふれているか否か
        }               //全てのボールをチェック
        return false;   //基本的にはセーフ
    }					//ボールあふれているかチェック関数
}