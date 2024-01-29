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
        //イメージ変数の
        Image s;

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

        //画像の差し替え
        //s = s2.GetComponent<Image>();

        //上キーを押したら
        if (upArrowKey.wasPressedThisFrame)
        {
            //画像の差し替え
            s = s1.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        //左キーを押したら
        if (leftArrowKey.wasPressedThisFrame)
        {
            //画像の差し替え
            s = s2.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        //右キーを押したら
        if (rightArrowKey.wasPressedThisFrame)
        {
            //画像の差し替え
            s = s3.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        //下キーを押したら
        if (downArrowKey.wasPressedThisFrame)
        {
            //画像の差し替え
            s = s4.GetComponent<Image>();

            SetImage(s);

            attackFlag = true;
        }

        
    }

    //画像の差し替え処理
    void SetImage(Image image)
    {
        //nに1を足す
        n += 1;

        //nが5より大きくなったら1に戻す
        if (n > 5)
        {
            n = 1;
        }

        //nが1の時num1の画像を表示する
        if (n == 1)
        {
            image.sprite = sp1;
        }

        //nが2の時num2の画像を表示する
        if (n == 2)
        {
            image.sprite = sp2;
        }

        //nが3の時num3の画像を表示する
        if (n == 3)
        {
            image.sprite = sp3;
        }

        //nが4の時num4の画像を表示する
        if (n == 4)
        {
            image.sprite = sp4;
        }

        //nが5の時num5の画像を表示する
        if (n == 5)
        {
            image.sprite = sp5;
        }
    }
}
