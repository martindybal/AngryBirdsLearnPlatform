using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level19 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[1, 2] = TypPolicka.AngryBird;

            GameBoard[2, 2] = TypPolicka.Cesta;
            GameBoard[3, 2] = TypPolicka.Cesta;
            GameBoard[4, 2] = TypPolicka.Cesta;
            GameBoard[5, 2] = TypPolicka.Cesta;
            GameBoard[6, 2] = TypPolicka.Cesta;

            GameBoard[6, 3] = TypPolicka.Cesta;
            GameBoard[6, 4] = TypPolicka.Cesta;
            GameBoard[6, 5] = TypPolicka.Cesta;
            GameBoard[6, 6] = TypPolicka.Cesta;

            GameBoard[5, 6] = TypPolicka.Cesta;
            GameBoard[4, 6] = TypPolicka.Cesta;
            GameBoard[3, 6] = TypPolicka.Cesta;


            GameBoard[1, 6] = TypPolicka.Cesta;
            GameBoard[2, 5] = TypPolicka.Cesta;
            GameBoard[5, 5] = TypPolicka.Cesta;
            GameBoard[2, 3] = TypPolicka.Cesta;
            GameBoard[4, 1] = TypPolicka.Cesta;

            GameBoard[2, 6] = TypPolicka.Prase;
        }
    }
}