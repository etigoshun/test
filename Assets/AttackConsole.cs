using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using JetBrains.Annotations;

namespace CardShuffule
{
    public class AttackConsole : CardShffule
    {
        //�_���[�W�e�L�X�g
        public Text damageTextCoponent;

        public Enemy enemy;

        //�_���[�W
        private int damage;

        // Start is called before the first frame update
        void Start()
        {
            damage = 0;
        }

        // Update is called once per frame
        void Update()
        {
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

            

            if (upArrowKey.wasPressedThisFrame)
            {
                damage += 10;
            }

            if (downArrowKey.wasPressedThisFrame)
            {
                damage += 15;
            }

            if (rightArrowKey.wasPressedThisFrame)
            {
                damage += 2;
            }

            if (leftArrowKey.wasPressedThisFrame)
            {
                damage += 320;
            }

            if (spaceKey.wasPressedThisFrame)
            {
                damageTextCoponent.text = damage + "�_���[�W";
                Debug.Log(damage + "�_���[�W");

                enemy.HPDamage(damage);

                damage = 0;
            }
        }

        //�_���[�W�̃Q�b�^�[
        public int GetDamage()
        {
            return damage;
        }
    }
}
