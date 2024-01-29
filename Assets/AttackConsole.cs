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
        //ダメージテキスト
        public Text damageTextCoponent;

        public Enemy enemy;

        //ダメージ
        private int damage;

        // Start is called before the first frame update
        void Start()
        {
            damage = 0;
        }

        // Update is called once per frame
        void Update()
        {
            //現在のキーボード情報
            var current = Keyboard.current;

            //キーボード接続チェック
            if (current == null)
            {
                //キーボードが接続されてないとKeyboard.currentがnullになる
                return;
            }

            //キーの入力状態取得
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
                damageTextCoponent.text = damage + "ダメージ";
                Debug.Log(damage + "ダメージ");

                enemy.HPDamage(damage);

                damage = 0;
            }
        }

        //ダメージのゲッター
        public int GetDamage()
        {
            return damage;
        }
    }
}
