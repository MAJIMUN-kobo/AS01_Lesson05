using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    // === �ϐ��̐錾
    public float moveSpeed;     // �ړ����x
    public int animationPattern;// �ړ��A�j���[�V�����̏�Ԕԍ�

    void Start()
    {
        
    }

    void Update()
    {
        this.TsMovement();  // �ړ����\�b�h�����s(Translate)

        this.PosMovement(); // �ړ����\�b�h�����s(Position)

        this.AnimationPatternUpdate();  // �A�j���[�V�����̏�ԑJ�ڂ����s
    }

    // === Translate��p�����ړ����\�b�h
    void TsMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, this.moveSpeed * Time.deltaTime, 0);
            animationPattern = 4;   // Back�̃A�j���[�V����
        }

        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-this.moveSpeed * Time.deltaTime, 0, 0);
            animationPattern = 2;   // Left�̃A�j���[�V����
        }

        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -this.moveSpeed * Time.deltaTime, 0);
            animationPattern = 1;   // Forward�̃A�j���[�V����
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(this.moveSpeed * Time.deltaTime, 0, 0);
            animationPattern = 3;   // Right�̃A�j���[�V����
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

    // === �A�j���[�V�����p�^�[���̏�ԑJ�ڃ��\�b�h
    void AnimationPatternUpdate()
    {
        switch( animationPattern )
        {
            case 0:
                // �A�j���[�V������ 0�� �ɐ؂�ւ��鏈��
                this.GetComponent<Animator>().SetInteger("AnimPattern", 0);
                break;

            case 1:
                // �A�j���[�V������ 1�� �ɐ؂�ւ��鏈��
                this.GetComponent<Animator>().SetInteger("AnimPattern", 1);
                break;

            case 2:
                // �A�j���[�V������ 2�� �ɐ؂�ւ��鏈��
                this.GetComponent<Animator>().SetInteger("AnimPattern", 2);
                break;

            case 3:
                // �A�j���[�V������ 3�� �ɐ؂�ւ��鏈��
                this.GetComponent<Animator>().SetInteger("AnimPattern", 3);
                break;

            case 4:
                // �A�j���[�V������ 4�� �ɐ؂�ւ��鏈��
                this.GetComponent<Animator>().SetInteger("AnimPattern", 4);
                break;
        }
    }
}
