using AngryBirds.Engine;
using AngryBirds.Engine.Localization;

namespace AngryBirds.Levels
{
    class Level1 : Level
    {
        protected override void InitBoard()
        {
            AngryBirdTurn = TurnType.Turn270;
            GameBoard[3, 2] = TypPolicka.AngryBird;
            GameBoard[3, 3] = TypPolicka.Cesta;
            GameBoard[3, 4] = TypPolicka.Prase;
        }
    }
}