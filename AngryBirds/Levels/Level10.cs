﻿using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level10 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[1, 4] = TypPolicka.AngryBird;
            GameBoard[2, 4] = TypPolicka.Cesta;
            GameBoard[3, 4] = TypPolicka.Cesta;
            GameBoard[4, 4] = TypPolicka.Cesta;
            GameBoard[5, 4] = TypPolicka.Cesta;
            GameBoard[6, 4] = TypPolicka.Prase;
        }
    }
}