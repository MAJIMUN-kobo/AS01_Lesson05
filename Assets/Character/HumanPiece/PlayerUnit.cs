using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    // === �ϐ��̐錾
    public float moveSpeed;     // �ړ����x

    void Start()
    {
        
    }

    void Update()
    {
        this.TsMovement();  // �ړ����\�b�h�����s(Translate)

        this.PosMovement(); // �ړ����\�b�h�����s(Position)
    }

    // === Translate��p�����ړ����\�b�h
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

    // === Position�𒼐ڏ�������ړ����\�b�h
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

        // �I�u�W�F�N�g�̍��W���X�V����
        this.transform.position = pos;
    }
}
