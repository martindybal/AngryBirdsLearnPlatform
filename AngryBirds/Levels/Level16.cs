using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level16 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn180;

            GameBoard[6, 1] = TypPolicka.AngryBird;

            GameBoard[5, 1] = TypPolicka.Cesta;
            GameBoard[4, 1] = TypPolicka.Cesta;
            GameBoard[3, 1] = TypPolicka.Cesta;
            GameBoard[2, 1] = TypPolicka.Cesta;
            GameBoard[1, 1] = TypPolicka.Cesta;

            GameBoard[1, 2] = TypPolicka.Cesta;
            GameBoard[1, 3] = TypPolicka.Cesta;
            GameBoard[1, 4] = TypPolicka.Cesta;
            GameBoard[1, 5] = TypPolicka.Cesta;
            GameBoard[1, 6] = TypPolicka.Cesta;

            GameBoard[2, 6] = TypPolicka.Cesta;
            GameBoard[3, 6] = TypPolicka.Cesta;
            GameBoard[4, 6] = TypPolicka.Cesta;
            GameBoard[5, 6] = TypPolicka.Cesta;
            GameBoard[6, 6] = TypPolicka.Cesta;

            GameBoard[6, 5] = TypPolicka.Cesta;
            GameBoard[6, 4] = TypPolicka.Cesta;

            GameBoard[5, 4] = TypPolicka.Cesta;

            GameBoard[4, 4] = TypPolicka.Prase;
        }
    }
}