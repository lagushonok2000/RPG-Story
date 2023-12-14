using Articy.Unity;
using System.Collections.Generic;
using UnityEngine;

public class ArticyHandler : MonoBehaviour, IArticyFlowPlayerCallbacks
{
    [SerializeField] private GameObject _articyDialogObject;

    public void OnBranchesUpdated(IList<Branch> aBranches) { }

    public void OnFlowPlayerPaused(IFlowObject aObject)
    {
        if(aObject == null)
        {
            _articyDialogObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}