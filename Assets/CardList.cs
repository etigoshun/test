using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CardList : MonoBehaviour
{
    //カードデッキの構造体
    public struct Card
    {
        //カードの数字
        public int cardNum;

        public Card(int cardNum)
        {
            this.cardNum = cardNum;
        }
    }

    //カードを保持するリスト
    List<Card> cardList;

    //デッキのカードの枚数
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
        //山札を初期化する
        cardList = new List<Card>();

        for (int i = 1; i <= numberInDeck; i++)
        {
            Card card = new Card(i);

            cardList.Add(card);
        }
    }

    void ShowCardName()
    {
        //コンソールに出力する文字列を生成
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
       

        string cardText = sb.ToString();
        //最後のカンマだけ削除する
        cardText = cardText.Remove(cardText.LastIndexOf(","));
        Debug.Log(cardText);
    }

    //void ShuffleCards()
    //{
    //    //カードをシャッフルする
    //    for (int i = 0; i < cardList.Count; i++)
    //    {
    //        Card temp = cardList[i];
    //        int randomIndex = Random.Range(0, cardList.Count);
    //        cardList[i] = cardList[randomIndex];
    //        cardList[randomIndex] = temp;
    //    }
    //}
}
