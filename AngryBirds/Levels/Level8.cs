using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level8 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[2, 6] = TypPolicka.AngryBird;
            GameBoard[3, 6] = TypPolicka.Cesta;
            GameBoard[4, 6] = TypPolicka.Cesta;
            GameBoard[5, 6] = TypPolicka.Cesta;
            GameBoard[6, 6] = TypPolicka.Cesta;
            GameBoard[6, 5] = TypPolicka.Cesta;
            GameBoard[6, 4] = TypPolicka.Cesta;
            GameBoard[6, 3] = TypPolicka.Cesta;
            GameBoard[6, 2] = TypPolicka.Cesta;
            GameBoard[6, 1] = TypPolicka.Prase;
        }
    }
}