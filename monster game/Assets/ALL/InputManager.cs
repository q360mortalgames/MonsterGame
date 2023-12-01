
using UnityEngine;

public class InputManager : MonoBehaviour {


    public string achievement_firstwin, achievement_bestlaptime, achievement_lapknockoutwinner, achievement_circuitwinner, achievement_eliminationwinner;

    // //achievement_firstwin  

    public void Achievement_firstwin()
    {
        AchievementsManager.Achievement_firstwin(achievement_firstwin, 1);
    }

    public void Achievement_bestlaptime()
    {
        AchievementsManager.Achievement_bestlaptime(achievement_bestlaptime, 1);
    }

    public void Achievement_lapknockoutwinner()
    {
        AchievementsManager.Achievement_lapknockoutwinner(achievement_lapknockoutwinner, 1);
    }

    public void Achievement_circuitwinner()
    {
        AchievementsManager.Achievement_circuitwinner(achievement_circuitwinner, 1);
    }

    public void Achievement_eliminationwinner()
    {
        AchievementsManager.Achievement_eliminationwinner(achievement_eliminationwinner, 1);
    }






}
