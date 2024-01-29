using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputExsample : MonoBehaviour
{


    private void Update()
    {
        //transformを取得
        Transform myTransform = this.transform;

        //座標を取得
        Vector3 pos = myTransform.position;

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

        //上アローキーを押したときの処理
        if (upArrowKey.isPressed)
        {
            pos.y += 0.1f;
        }

        //下アローキーを押したときの処理
        if (downArrowKey.isPressed)
        {
            pos.y -= 0.1f;
        }

        //左アローキーを押したときの処理
        if (leftArrowKey.isPressed)
        {
            pos.x -= 0.1f;
        }

        //右アローキーを押したときの処理
        if (rightArrowKey.isPressed)
        {
            pos.x += 0.1f;
        }

        //座標を設定
        myTransform.position = pos;
    }
}
