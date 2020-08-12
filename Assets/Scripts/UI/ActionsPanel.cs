using System;
using CatSimulator.Core;
using CatSimulator.Data;
using UnityEngine;

namespace CatSimulator.UI
{
    
    public class ActionsPanel : MonoBehaviour
    {
        public GameObject slotInstance;

        private CatController catController;

        // -----------------------------------------------------------------
        public void Init(CatController catController)
        {
            this.catController = catController;

            foreach (CatAction action in Enum.GetValues(typeof(CatAction)))
            {
                GameObject obj = Instantiate(slotInstance, transform);
                ActionButton actionButton = obj.GetComponent<ActionButton>();
                actionButton.Init(action, OnActionButtonClick);
            }
        }

        // -----------------------------------------------------------------
        void Start()
        {
            slotInstance.transform.SetParent(null);
        }
        
        // -----------------------------------------------------------------
        void OnActionButtonClick(CatAction action)
        {
            catController.ProcessAction(action);
        }
    }
}
