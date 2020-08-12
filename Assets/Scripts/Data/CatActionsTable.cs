using System;
using System.Collections.Generic;

namespace CatSimulator.Data
{
    // ********************************************************************
    public class CatActionsTable
    {
        private Dictionary<CatActionTableKey, CatActionReaction> actionTable;
        
        // -----------------------------------------------------------------
        public CatActionsTable()
        {
            InitTable();
        }
        
        // -----------------------------------------------------------------
        public CatActionReaction GetCatActionReaction(CatActionTableKey tableKey)
        {
            if(!actionTable.ContainsKey(tableKey)) throw new Exception("Error: No such CatActionTableKey in CatActionsTable");
            return actionTable[tableKey];
        }
        
        // -----------------------------------------------------------------
        private void InitTable()
        {
            actionTable = new Dictionary<CatActionTableKey, CatActionReaction>();

            // BAD MOOD
            actionTable[new CatActionTableKey(CatMood.BAD, CatAction.PLAY)] =
                new CatActionReaction(CatReaction.SITTING);
            actionTable[new CatActionTableKey(CatMood.BAD, CatAction.FEED)] =
                new CatActionReaction(CatReaction.EATING_AND_SCRATCHES, CatMood.GOOD);
            actionTable[new CatActionTableKey(CatMood.BAD, CatAction.CARESS)] =
                new CatActionReaction(CatReaction.SCRATCHES);
            actionTable[new CatActionTableKey(CatMood.BAD, CatAction.KICK)] =
                new CatActionReaction(CatReaction.JUMP_AND_BITES);
            
            // GOOD MOOD
            actionTable[new CatActionTableKey(CatMood.GOOD, CatAction.PLAY)] =
                new CatActionReaction(CatReaction.SLOWLY_RUNNING_WITH_BALL, CatMood.EXCELLENT);
            actionTable[new CatActionTableKey(CatMood.GOOD, CatAction.FEED)] =
                new CatActionReaction(CatReaction.EAT_ALL_FAST, CatMood.EXCELLENT);
            actionTable[new CatActionTableKey(CatMood.GOOD, CatAction.CARESS)] =
                new CatActionReaction(CatReaction.PURRS, CatMood.EXCELLENT);
            actionTable[new CatActionTableKey(CatMood.GOOD, CatAction.KICK)] =
                new CatActionReaction(CatReaction.RUN_AND_PISS_AND_CARPET, CatMood.BAD);
            
            // EXCELLENT MOOD
            actionTable[new CatActionTableKey(CatMood.EXCELLENT, CatAction.PLAY)] =
                new CatActionReaction(CatReaction.RUNNING_CRAZY);
            actionTable[new CatActionTableKey(CatMood.EXCELLENT, CatAction.FEED)] =
                new CatActionReaction(CatReaction.EAT_ALL_FAST);
            actionTable[new CatActionTableKey(CatMood.EXCELLENT, CatAction.CARESS)] =
                new CatActionReaction(CatReaction.PURRS_AND_WAGGING_TAIL);
            actionTable[new CatActionTableKey(CatMood.EXCELLENT, CatAction.KICK)] =
                new CatActionReaction(CatReaction.RUNS_TO_ANOTHER_ROOM, CatMood.BAD);
        }
    }
    
    // ********************************************************************
    public struct CatActionTableKey
    {
        public readonly CatMood mood;
        public readonly CatAction action;
        
        // -----------------------------------------------------------------
        public CatActionTableKey(CatMood mood, CatAction action)
        {
            this.action = action;
            this.mood = mood;
        }
    }

    // ********************************************************************
    public struct CatActionReaction
    {
        public readonly CatReaction reaction;
        public readonly CatMood? newMood; // null if we wont change cat's mood
        
        // -----------------------------------------------------------------
        public CatActionReaction(CatReaction reaction, CatMood newMood)
        {
            this.reaction = reaction;
            this.newMood = newMood;
        }

        // -----------------------------------------------------------------
        public CatActionReaction(CatReaction reaction)
        {
            this.reaction = reaction;
            newMood = null;
        }
    }
    
}