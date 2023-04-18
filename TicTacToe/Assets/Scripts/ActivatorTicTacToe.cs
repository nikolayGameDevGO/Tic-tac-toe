using UnityEngine;

public class ActivatorTicTacToe : MonoBehaviour
{
    [SerializeField] private GameObject _crossGO;
    [SerializeField] private GameObject _noGO;


    public void OnMouseDown()
    {
        if (SwitchPlayer._switchPlayer == true)
        {            
            ActiveNo();
        }
        if (SwitchPlayer._switchPlayer == false)
        {
            
            ActiveCross();
        }
    }

    public void ActiveCross()
    {
        SwitchPlayer.switchPlayer();
        if (_crossGO.activeInHierarchy == false) _crossGO.SetActive(true);
    }
    public void ActiveNo()
    {
        SwitchPlayer.switchPlayer();
        if (_noGO.activeInHierarchy == false) _noGO.SetActive(true);
    }



}
