using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level20 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn90;
            GameBoard[1, 6] = TypPolicka.AngryBird;

            GameBoard[1, 5] = TypPolicka.Cesta;
            GameBoard[1, 4] = TypPolicka.Cesta;

            GameBoard[2, 4] = TypPolicka.Cesta;
            GameBoard[3, 4] = TypPolicka.Cesta;

            GameBoard[3, 5] = TypPolicka.Cesta;

            GameBoard[4, 5] = TypPolicka.Cesta;
            GameBoard[5, 5] = TypPolicka.Cesta;

            GameBoard[5, 4] = TypPolicka.Cesta;
            GameBoard[5, 3] = TypPolicka.Cesta;
            GameBoard[5, 2] = TypPolicka.Cesta;

            GameBoard[4, 2] = TypPolicka.Cesta;
            GameBoard[3, 2] = TypPolicka.Cesta;
            GameBoard[2, 2] = TypPolicka.Cesta;

            GameBoard[2, 1] = TypPolicka.Prase;
        }
    }
}