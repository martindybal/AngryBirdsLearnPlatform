using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level7 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[4, 2] = TypPolicka.AngryBird;
            GameBoard[4, 3] = TypPolicka.Cesta;
            GameBoard[4, 4] = TypPolicka.Cesta;
            GameBoard[4, 5] = TypPolicka.Cesta;
            GameBoard[4, 6] = TypPolicka.Cesta;
            GameBoard[4, 7] = TypPolicka.Prase;
        }
    }
}