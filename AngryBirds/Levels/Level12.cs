using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level12 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[0, 7] = TypPolicka.AngryBird;
            GameBoard[1, 7] = TypPolicka.Cesta;
            GameBoard[1, 6] = TypPolicka.Cesta;
            GameBoard[2, 6] = TypPolicka.Cesta;
            GameBoard[2, 5] = TypPolicka.Cesta;
            GameBoard[3, 5] = TypPolicka.Cesta;
            GameBoard[3, 4] = TypPolicka.Cesta;
            GameBoard[4, 4] = TypPolicka.Cesta;
            GameBoard[4, 3] = TypPolicka.Cesta;
            GameBoard[5, 3] = TypPolicka.Cesta;
            GameBoard[5, 2] = TypPolicka.Cesta;
            GameBoard[6, 2] = TypPolicka.Cesta;
            GameBoard[6, 1] = TypPolicka.Prase;
        }
    }
}