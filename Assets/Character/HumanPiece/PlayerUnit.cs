using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    // === 変数の宣言
    public float moveSpeed;     // 移動速度

    void Start()
    {
        
    }

    void Update()
    {
        this.TsMovement();  // 移動メソッドを実行(Translate)

        this.PosMovement(); // 移動メソッドを実行(Position)
    }

    // === Translateを用いた移動メソッド
    void TsMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, this.moveSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-this.moveSpeed * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -this.moveSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(this.moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    // === Positionを直接書換える移動メソッド
    void PosMovement()
    {
        Vector3 pos = this.transform.position;

        if(Input.GetKey(KeyCode.UpArrow)) {
            pos.y += this.moveSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.LeftArrow)) {
            pos.x += -this.moveSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.DownArrow)) {
            pos.y += -this.moveSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow)) {
            pos.x += this.moveSpeed * Time.deltaTime;
        }

        // オブジェクトの座標を更新する
        this.transform.position = pos;
    }
}
