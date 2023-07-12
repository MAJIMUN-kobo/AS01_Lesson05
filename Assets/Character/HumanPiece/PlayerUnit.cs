using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    // === 変数の宣言
    public float moveSpeed;     // 移動速度
    public int animationPattern;// 移動アニメーションの状態番号

    void Start()
    {
        
    }

    void Update()
    {
        this.TsMovement();  // 移動メソッドを実行(Translate)

        this.PosMovement(); // 移動メソッドを実行(Position)

        this.AnimationPatternUpdate();  // アニメーションの状態遷移を実行
    }

    // === Translateを用いた移動メソッド
    void TsMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, this.moveSpeed * Time.deltaTime, 0);
            animationPattern = 4;   // Backのアニメーション
        }

        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-this.moveSpeed * Time.deltaTime, 0, 0);
            animationPattern = 2;   // Leftのアニメーション
        }

        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -this.moveSpeed * Time.deltaTime, 0);
            animationPattern = 1;   // Forwardのアニメーション
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(this.moveSpeed * Time.deltaTime, 0, 0);
            animationPattern = 3;   // Rightのアニメーション
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

    // === アニメーションパターンの状態遷移メソッド
    void AnimationPatternUpdate()
    {
        switch( animationPattern )
        {
            case 0:
                // アニメーションを 0番 に切り替える処理
                this.GetComponent<Animator>().SetInteger("AnimPattern", 0);
                break;

            case 1:
                // アニメーションを 1番 に切り替える処理
                this.GetComponent<Animator>().SetInteger("AnimPattern", 1);
                break;

            case 2:
                // アニメーションを 2番 に切り替える処理
                this.GetComponent<Animator>().SetInteger("AnimPattern", 2);
                break;

            case 3:
                // アニメーションを 3番 に切り替える処理
                this.GetComponent<Animator>().SetInteger("AnimPattern", 3);
                break;

            case 4:
                // アニメーションを 4番 に切り替える処理
                this.GetComponent<Animator>().SetInteger("AnimPattern", 4);
                break;
        }
    }
}
