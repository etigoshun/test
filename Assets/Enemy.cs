using CardShuffule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    //�c��HP�̃e�L�X�g
    public Text hpTextCoponent;

    //HP
    private int hp;

    //�_���[�W��ۑ�����ϐ�
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

        hpTextCoponent.text = "�c��HP" + hp;
    }

    public void HPDamage(int damage)
    {
        hp -= damage;
    }
}
