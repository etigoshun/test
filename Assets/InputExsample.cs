using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputExsample : MonoBehaviour
{


    private void Update()
    {
        //transform���擾
        Transform myTransform = this.transform;

        //���W���擾
        Vector3 pos = myTransform.position;

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

        //��A���[�L�[���������Ƃ��̏���
        if (upArrowKey.isPressed)
        {
            pos.y += 0.1f;
        }

        //���A���[�L�[���������Ƃ��̏���
        if (downArrowKey.isPressed)
        {
            pos.y -= 0.1f;
        }

        //���A���[�L�[���������Ƃ��̏���
        if (leftArrowKey.isPressed)
        {
            pos.x -= 0.1f;
        }

        //�E�A���[�L�[���������Ƃ��̏���
        if (rightArrowKey.isPressed)
        {
            pos.x += 0.1f;
        }

        //���W��ݒ�
        myTransform.position = pos;
    }
}
