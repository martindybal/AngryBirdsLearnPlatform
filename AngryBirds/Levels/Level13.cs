using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level13 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[1, 1] = TypPolicka.AngryBird;
            GameBoard[1, 2] = TypPolicka.Cesta;
            GameBoard[2, 2] = TypPolicka.Cesta;
            GameBoard[2, 3] = TypPolicka.Cesta;
            GameBoard[3, 3] = TypPolicka.Cesta;
            GameBoard[3, 4] = TypPolicka.Cesta;
            GameBoard[4, 4] = TypPolicka.Cesta;
            GameBoard[4, 5] = TypPolicka.Cesta;
            GameBoard[5, 5] = TypPolicka.Cesta;
            GameBoard[5, 6] = TypPolicka.Cesta;
            GameBoard[6, 6] = TypPolicka.Prase;
        }
    }
}