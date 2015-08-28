using AngryBirds.Engine.Interfaces;
using AngryBirds.Engine.Localization;
using AngryBirds.Levels;

namespace AngryBirds.Engine.Implementation
{
    public class GameBoard : IGameBoard
    {
        public Level Level { get; set; }
        public int NextField(ICharacter character)
        {
            int x = character.PositionX;
            int y = character.PositionY;
            switch (character.ActualTurn)
            {
                case TurnType.Turn0:
                    x++;
                    break;
                case TurnType.Turn90:
                    y--;
                    break;
                case TurnType.Turn180:
                    x--;
                    break;
                case TurnType.Turn270:
                    y++;
                    break;
            }
            if (x >= Level.BorderSize || y >= Level.BorderSize)
            {
                return TypPolicka.Prekazka;
            }
            return Level.GameBoard[x, y];
        }

        public int OnField(ICharacter character)
        {
            return Level.GameBoard[character.PositionX, character.PositionY];
        }
    }
}