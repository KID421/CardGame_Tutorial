using UnityEngine;
using UnityEngine.SceneManagement;

public class FifteenManager : MonoBehaviour
{
    public Sprite[] images;

    private Card[] cardPlayer = new Card[2], cardPC = new Card[2];

    public TextMesh tipBottom, tipMiddle;

    private void Start()
    {
        Deal(0, 8);
    }

    private void Update()
    {
        if (cardPlayer[0] != null && cardPlayer[1] == null)
        {
            tipBottom.text = "請按空白鍵發下一張牌";

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Deal(1, 4);
                Check();
            }
        }
        if (tipMiddle.text != "" && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void Deal(int cardNumber, int cardPosition)
    {
        int rPlayer = Random.Range(0, 10);
        cardPlayer[cardNumber] = new Card(rPlayer, -cardPosition, images[rPlayer]);

        int rPC = Random.Range(0, 10);
        cardPC[cardNumber] = new Card(rPC, cardPosition, images[rPC]);
    }

    private void Check()
    {
        int totalPlayer = cardPlayer[0].number + cardPlayer[1].number;
        int totalPC = cardPC[0].number + cardPC[1].number;

        if (totalPlayer > 15 && totalPC > 15)
        {
            tipMiddle.text = "平手";
        }
        else if (totalPlayer > 15)
        {
            tipMiddle.text = "失敗";
        }
        else if (totalPC > 15)
        {
            tipMiddle.text = "獲勝";
        }
        else if (totalPlayer > totalPC)
        {
            tipMiddle.text = "獲勝";
        }
        else if (totalPlayer < totalPC)
        {
            tipMiddle.text = "失敗";
        }
        else
        {
            tipMiddle.text = "平手";
        }

        tipBottom.text = "請按 R 重新遊戲";
    }
}
