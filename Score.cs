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
        if (collision.gameObject/*(<-勘で書いた注意)自分と同じボールと衝突する*/)
        {
            Destroy(this.gameObject);
            /*一つ上の番号をボールを中間座標に生成する*/
        }
    }
}