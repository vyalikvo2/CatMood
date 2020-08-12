using TMPro;
using UnityEngine;
using CatSimulator.Data;

namespace CatSimulator.UI
{
    
    public delegate void OnActionButtonClickDelegate(CatAction action);
    
    public class ActionButton : MonoBehaviour
    {
        private CatAction action;
        private OnActionButtonClickDelegate OnActionButtonClick; // button click callback

        [SerializeField] private TMP_Text textFieldCaption;
        
        // -----------------------------------------------------------------
        public void Init(CatAction action, OnActionButtonClickDelegate OnActionButtonClick)
        {
            this.action = action;
            this.OnActionButtonClick = OnActionButtonClick;
            
            textFieldCaption.text = CatStrings.GetByAction(action);;
        }

        // -----------------------------------------------------------------
        public void OnButtonClick()
        {
            if (OnActionButtonClick != null) OnActionButtonClick(action);
        }
    }
}
