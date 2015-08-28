using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level4 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn0;
            GameBoard[2, 4] = TypPolicka.AngryBird;
            GameBoard[3, 4] = TypPolicka.Cesta;
            GameBoard[3, 3] = TypPolicka.Cesta;
            GameBoard[4, 3] = TypPolicka.Prase;
        }
    }
}