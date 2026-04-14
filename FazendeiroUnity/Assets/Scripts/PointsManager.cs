using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public static PointsManager instance;
    public TextMeshProUGUI pontos;
    int score = 0;
    void Start()
    {
        pontos.text = "Pontos: " + score.ToString();
    }
    private void Awake()
    {
        instance = this;
    }
    public void AlterPoints(int p)
    {
        score += p;
        pontos.text = "Pontos: " + score.ToString();
    }
}
