using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string start;
    [SerializeField] private string menu;
    [SerializeField] private GameObject painelInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelSaida;
    public void Play()
    {
        SceneManager.LoadScene(start);
        Time.timeScale = 1;
    }
    public void Menu()
    {
        SceneManager.LoadScene(menu);
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
    public void TouchQuit()
    {
        painelInicial.SetActive(false);
        painelSaida.SetActive(true);
    }
    public void ReturnQuit()
    {
        painelSaida.SetActive(false);
        painelInicial.SetActive(true);
    }
    public void ConfirmQuit()
    {
        Application.Quit();
    }
}
