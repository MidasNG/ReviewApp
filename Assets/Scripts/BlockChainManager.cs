using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class BlockChainManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI balanceText;

    [SerializeField] private TextMeshProUGUI reviewInput;

    [SerializeField] private BalanceManager balanceManager;

    [SerializeField] private GameObject reviewPanel, startPanel;

    private string tokenContract = "0x4920248dE95aDbE659768948b185552bb8E8147d";

    private ThirdwebSDK sdk;


    void Start()
    {
        sdk = ThirdwebManager.Instance.SDK;
    }

    //Hay una referencia a esta función en Prefab_ConnectWallet, en la parte de OnConnected()
    public void OnConnected()
    {
        GetTokenBalance();
    }

    private async void GetTokenBalance()
    {
        string address = await sdk.Wallet.GetAddress();

        Contract contract = sdk.GetContract(tokenContract);

        var data = await contract.ERC20.BalanceOf(address);

        balanceText.text = "Balance: " + data.displayValue;
    }

    public /*async*/ void ClaimTokens()
    {
        if (reviewInput.text.Length > 5)
        {
            /*Contract contract = sdk.GetContract(tokenContract);

            var data = await contract.ERC20.Claim("10");

            GetTokenBalance();*/

            print("10 Tokens Recibidos!");
            Debug.Log("Para que la transacción sea real, hay que descomentar la parte de código necesaria en BlockChainManager");
            balanceManager.RaiseBalance(10);

            reviewInput.text = null;
            reviewPanel.SetActive(false);
            startPanel.SetActive(true);
        }
        else print("Escriba una reseña de al menos 5 caracteres");
    }
}
