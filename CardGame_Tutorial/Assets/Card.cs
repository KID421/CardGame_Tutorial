using UnityEngine;

public class Card
{
    private int _number;
    private float _x;
    private Sprite _image;

    public int number { get => _number; }
    public float x { get => _x; set => _x = value; }
    public Sprite image { get => _image; }

    public Card(int getNumber, float getX, Sprite getImage)
    {
        _number = getNumber;
        _x = getX;
        _image = getImage;
        GameObject temp = new GameObject("卡片");
        temp.AddComponent<SpriteRenderer>();
        temp.GetComponent<SpriteRenderer>().sprite = image;
        temp.transform.position = new Vector2(x, 0);
    }
}
