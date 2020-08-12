using System;

namespace CatSimulator.Data
{       
    // ********************************************************************
    public enum CatReaction
    {
        SITTING,
        EATING_AND_SCRATCHES,
        SCRATCHES,
        JUMP_AND_BITES,
        SLOWLY_RUNNING_WITH_BALL,
        EAT_ALL_FAST,
        PURRS,
        RUN_AND_PISS_AND_CARPET,
        RUNNING_CRAZY,
        PURRS_AND_WAGGING_TAIL,
        RUNS_TO_ANOTHER_ROOM
    }
    
    // ********************************************************************
    public enum CatAction
    {
        PLAY,
        FEED,
        CARESS,
        KICK
    }
    
    // ********************************************************************
    public enum CatMood
    {
        BAD,
        GOOD,
        EXCELLENT
    }
    
    
    // ********************************************************************
    class CatStrings
    {    
        // -----------------------------------------------------------------
        public static string GetByMood(CatMood mood)
        {
            switch (mood)
            {
                case CatMood.BAD:
                    return "Плохое";
                case CatMood.GOOD:
                    return "Хорошее";
                case CatMood.EXCELLENT:
                    return "Отличное";
                default:
                    throw new Exception("Error: No such CatMood in strings");
            }
        }   
        
        // -----------------------------------------------------------------
        public static string GetByAction(CatAction action)
        {
            switch (action)
            {
                case CatAction.PLAY:
                    return "Поиграть";
                case CatAction.FEED:
                    return "Накормить";
                case CatAction.CARESS:
                    return "Погладить";
                case CatAction.KICK:
                    return "Дать пинка";
                default:
                    throw new Exception("Error: No such CatAction in strings");
            }
        }     
        
        // -----------------------------------------------------------------
        public static string GetByReaction(CatReaction reaction)
        {
            switch (reaction)
            {
                case CatReaction.SITTING:
                    return "Сидит на месте.";
                case CatReaction.EATING_AND_SCRATCHES:
                    return "Все съедает, но если в это время подойти - поцарапает.";
                case CatReaction.SCRATCHES:
                    return "Царапает.";
                case CatReaction.JUMP_AND_BITES:
                    return "Прыгает и кусает за правое ухо.";
                case CatReaction.SLOWLY_RUNNING_WITH_BALL:
                    return "Медленно бегает за мячиком.";
                case CatReaction.EAT_ALL_FAST:
                    return "Быстро все съедает.";
                case CatReaction.PURRS:
                    return "Мурлычет.";
                case CatReaction.RUN_AND_PISS_AND_CARPET:
                    return "Убегает на ковер и писает.";
                case CatReaction.RUNNING_CRAZY:
                    return "Носится как угорелая.";
                case CatReaction.PURRS_AND_WAGGING_TAIL:
                    return "Мурлычет и виляет хвостом.";
                case CatReaction.RUNS_TO_ANOTHER_ROOM:
                    return "Убегает в другую комнату.";
                default:
                    throw new Exception("Error: No such CatReaction in strings");
            }
        }
    }
}
