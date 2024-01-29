using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class CardShffule : MonoBehaviour
{
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp3;
    public Sprite sp4;
    public Sprite sp5;

    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;

    int n = 1;

    protected bool attackFlag = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //�C���[�W�ϐ���
        Image s;

        //���݂̃L�[�{�[�h���
        var current = Keyboard.current;

        //�L�[�{�[�h�ڑ��`�F�b�N
        if (current == null)
        {
            //�L�[�{�[�h���ڑ�����ĂȂ���Keyboard.current��null�ɂȂ�
            return;
        }

        //�L�[�̓��͏�Ԏ擾
        var upArrowKey = current.upArrowKey;
        var downArrowKey = current.downArrowKey;
        var leftArrowKey = current.leftArrowKey;
        var rightArrowKey = current.rightArrowKey;
        var spaceKey = current.spaceKey;

        //�摜�̍����ւ�
        //s = s2.GetComponent<Image>();

        //��L�[����������
        if (upArrowKey.wasPressedThisFrame)
        {
            //�摜�̍����ւ�
            s = s1.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        //���L�[����������
        if (leftArrowKey.wasPressedThisFrame)
        {
            //�摜�̍����ւ�
            s = s2.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        //�E�L�[����������
        if (rightArrowKey.wasPressedThisFrame)
        {
            //�摜�̍����ւ�
            s = s3.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        //���L�[����������
        if (downArrowKey.wasPressedThisFrame)
        {
            //�摜�̍����ւ�
            s = s4.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        
    }

    //�摜�̍����ւ�����
    void SetImage(Image image)
    {
        //n��1�𑫂�
        n += 1;

        //n��5���傫���Ȃ�����1�ɖ߂�
        if (n > 5)
        {
            n = 1;
        }

        //n��1�̎�num1�̉摜��\������
        if (n == 1)
        {
            image.sprite = sp1;
        }

        //n��2�̎�num2�̉摜��\������
        if (n == 2)
        {
            image.sprite = sp2;
        }

        //n��3�̎�num3�̉摜��\������
        if (n == 3)
        {
            image.sprite = sp3;
        }

        //n��4�̎�num4�̉摜��\������
        if (n == 4)
        {
            image.sprite = sp4;
        }

        //n��5�̎�num5�̉摜��\������
        if (n == 5)
        {
            image.sprite = sp5;
        }
    }
}
