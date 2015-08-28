using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level17 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn270;
            GameBoard[5, 2] = TypPolicka.AngryBird;

            GameBoard[5, 3] = TypPolicka.Cesta;
            GameBoard[5, 4] = TypPolicka.Cesta;
            GameBoard[5, 5] = TypPolicka.Cesta;
            GameBoard[5, 6] = TypPolicka.Cesta;

            GameBoard[4, 6] = TypPolicka.Cesta;
            GameBoard[3, 6] = TypPolicka.Cesta;
            GameBoard[2, 6] = TypPolicka.Cesta;
            GameBoard[1, 6] = TypPolicka.Cesta;

            GameBoard[1, 5] = TypPolicka.Cesta;
            GameBoard[1, 4] = TypPolicka.Cesta;
            
            GameBoard[2, 4] = TypPolicka.Cesta;

            GameBoard[3, 4] = TypPolicka.Prase;
        }
    }
}