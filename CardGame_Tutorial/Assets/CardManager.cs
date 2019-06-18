using UnityEngine;

public class CardManager : MonoBehaviour
{
    public Sprite[] images;

    private Card cardPlayer, cardPC;

    public TextMesh tip;

    private void Start()
    {
        int rPlayer = Random.Range(1, 10);
        cardPlayer = new Card(rPlayer, -5, images[rPlayer - 1]);

        int rPC = Random.Range(1, 10);
        cardPC = new Card(rPC, 5, images[rPC - 1]);

        if (cardPlayer.number > cardPC.number)
        {
            tip.text = "獲勝";
        }
        else if (cardPlayer.number < cardPC.number)
        {
            tip.text = "失敗";
        }
        else
        {
            tip.text = "平手";
        }
    }
}
