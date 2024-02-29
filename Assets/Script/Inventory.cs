
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int chickensCount;
    public Text chickensCountText;
    public static Inventory instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("il y a plus d'une instance de Inventory dans la scene");
            return;
        }
        instance = this;
    }

    public void AddChickens(int Count)
    {
    chickensCount+=Count;
        chickensCountText.text = chickensCount.ToString();
}
}
