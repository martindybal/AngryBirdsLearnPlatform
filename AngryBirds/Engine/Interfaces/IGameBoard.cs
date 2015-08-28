using AngryBirds.Levels;

namespace AngryBirds.Engine.Interfaces
{
    public interface IGameBoard
    {
        Level Level { get; set; }
        int NextField(ICharacter character);
        int OnField(ICharacter character);
    }
}