using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public Score[] scores;            //�X�R�A�S�̂��Ǘ�
    void Start()
    {

    }
    void Update()
    {
        if (ScoreOver())
        {
            //�Q�[���I�[�o�[
        }
    }
    private bool ScoreOver()
    {
        foreach (Score s in scores)
        {
            if (s.transform.position.z > 10)
            {
                return true;
            }           //�{�[�������ӂ�Ă��邩�ۂ�
        }               //�S�Ẵ{�[�����`�F�b�N
        return false;   //��{�I�ɂ̓Z�[�t
    }					//�{�[�����ӂ�Ă��邩�`�F�b�N�֐�
}