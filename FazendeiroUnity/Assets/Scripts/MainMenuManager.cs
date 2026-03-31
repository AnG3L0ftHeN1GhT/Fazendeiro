using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string start;
    [SerializeField] private GameObject painelInicial;
    [SerializeField] private GameObject painelOpcoes;
    public void Play()
    {
        SceneManager.LoadScene(start);
    }
    public void OpenOptions()
    {
        painelInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void CloseOptions()
    {
        painelInicial.SetActive(true);
        painelOpcoes.SetActive(false);
    }
    public void Quit()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
