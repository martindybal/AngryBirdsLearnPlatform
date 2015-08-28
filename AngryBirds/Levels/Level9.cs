using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level9 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[2, 5] = TypPolicka.AngryBird;
            GameBoard[3, 5] = TypPolicka.Cesta;
            GameBoard[4, 5] = TypPolicka.Cesta;
            GameBoard[4, 4] = TypPolicka.Cesta;
            GameBoard[4, 3] = TypPolicka.Cesta;
            GameBoard[3, 3] = TypPolicka.Cesta;
            GameBoard[2, 3] = TypPolicka.Prase;
        }
    }
}