using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level14 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[3, 6] = TypPolicka.AngryBird;
            GameBoard[4, 6] = TypPolicka.Cesta;
            GameBoard[5, 6] = TypPolicka.Cesta;
            GameBoard[5, 5] = TypPolicka.Cesta;
            GameBoard[5, 4] = TypPolicka.Cesta;
            GameBoard[5, 3] = TypPolicka.Cesta;
            GameBoard[5, 2] = TypPolicka.Cesta;
            GameBoard[5, 1] = TypPolicka.Prase;
        }
    }
}