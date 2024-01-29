using CardShuffule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    //残りHPのテキスト
    public Text hpTextCoponent;

    //HP
    private int hp;

    //ダメージを保存する変数
    private int damage;

    // Start is called before the first frame update
    void Start()
    {
        damage = 0;
        hp = 10000;
    }

    // Update is called once per frame
    void Update()
    {

        hpTextCoponent.text = "残りHP" + hp;
    }

    public void HPDamage(int damage)
    {
        hp -= damage;
    }
}
