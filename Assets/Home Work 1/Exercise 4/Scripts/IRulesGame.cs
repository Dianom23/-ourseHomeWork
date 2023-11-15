using System;

namespace HomeWork1.Exercise4
{
    public interface IRulesGame
    {
        void CheckWin();
        bool TryBurstBall(Ball ball);
        event Action LoseGameEvent;
        event Action WinGameEvent;
    }
}
