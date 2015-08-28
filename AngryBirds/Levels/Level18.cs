using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level18 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[5, 6] = TypPolicka.AngryBird;

            GameBoard[6, 6] = TypPolicka.Cesta;

            GameBoard[6, 5] = TypPolicka.Cesta;
            GameBoard[6, 4] = TypPolicka.Cesta;
            GameBoard[6, 3] = TypPolicka.Cesta;

            GameBoard[5, 3] = TypPolicka.Cesta;
            GameBoard[4, 3] = TypPolicka.Cesta;
            GameBoard[3, 3] = TypPolicka.Cesta;
            GameBoard[2, 3] = TypPolicka.Cesta;
            GameBoard[1, 3] = TypPolicka.Cesta;

            GameBoard[2, 2] = TypPolicka.Cesta;
            GameBoard[3, 4] = TypPolicka.Cesta;
            GameBoard[3, 5] = TypPolicka.Cesta;

            GameBoard[0, 3] = TypPolicka.Prase;
        }
    }
}