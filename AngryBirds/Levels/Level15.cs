using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level15 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[2, 2] = TypPolicka.AngryBird;
            GameBoard[3, 2] = TypPolicka.Cesta;
            GameBoard[4, 2] = TypPolicka.Cesta;
            GameBoard[5, 2] = TypPolicka.Cesta;
            GameBoard[5, 3] = TypPolicka.Cesta;
            GameBoard[5, 4] = TypPolicka.Cesta;
            GameBoard[5, 5] = TypPolicka.Cesta;
            GameBoard[5, 6] = TypPolicka.Cesta;
            GameBoard[4, 6] = TypPolicka.Cesta;
            GameBoard[3, 6] = TypPolicka.Cesta;
            GameBoard[2, 6] = TypPolicka.Cesta;
            GameBoard[6, 4] = TypPolicka.Cesta;
            GameBoard[1, 6] = TypPolicka.Prase;
        }
    }
}