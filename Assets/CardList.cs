using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CardList : MonoBehaviour
{
    //�J�[�h�f�b�L�̍\����
    public struct Card
    {
        //�J�[�h�̐���
        public int cardNum;

        public Card(int cardNum)
        {
            this.cardNum = cardNum;
        }
    }

    //�J�[�h��ێ����郊�X�g
    List<Card> cardList;

    //�f�b�L�̃J�[�h�̖���
    const int numberInDeck = 18;

    // Start is called before the first frame update
    void Start()
    {
        InitializeCardList();
        ShowCardName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeCardList()
    {
        //�R�D������������
        cardList = new List<Card>();

        for (int i = 1; i <= numberInDeck; i++)
        {
            Card card = new Card(i);

            cardList.Add(card);
        }
    }

    void ShowCardName()
    {
        //�R���\�[���ɏo�͂��镶����𐶐�
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
       

        string cardText = sb.ToString();
        //�Ō�̃J���}�����폜����
        cardText = cardText.Remove(cardText.LastIndexOf(","));
        Debug.Log(cardText);
    }

    //void ShuffleCards()
    //{
    //    //�J�[�h���V���b�t������
    //    for (int i = 0; i < cardList.Count; i++)
    //    {
    //        Card temp = cardList[i];
    //        int randomIndex = Random.Range(0, cardList.Count);
    //        cardList[i] = cardList[randomIndex];
    //        cardList[randomIndex] = temp;
    //    }
    //}
}
