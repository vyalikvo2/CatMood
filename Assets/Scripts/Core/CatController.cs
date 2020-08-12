using CatSimulator.UI;
using CatSimulator.Data;
using UnityEngine;

namespace CatSimulator.Core
{
    
    public class CatController : MonoBehaviour
    {
        private CatActionsTable catActionsTable;
        private CatMood currentMood;
        
        [SerializeField] private ActionsPanel actionPanel;
        [SerializeField] private InfoPanel infoPanel;
        
        // -----------------------------------------------------------------
        void Start()
        {
            catActionsTable = new CatActionsTable();
            currentMood = CatMood.GOOD;

            actionPanel.Init(this);
            infoPanel.SetMood(currentMood);
        }
        
        // -----------------------------------------------------------------
        public void ProcessAction(CatAction action)
        {
            CatActionReaction reaction = catActionsTable.GetCatActionReaction(new CatActionTableKey(currentMood, action));

            if (reaction.newMood != null)
                currentMood = (CatMood) reaction.newMood;
            
            infoPanel.SetMood(currentMood);
            infoPanel.SetReaction(reaction.reaction);
        }
        
    }
}
