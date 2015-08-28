using AngryBirds.Engine.Implementation;

namespace AngryBirds.Engine.Localization
{
    public class HraciPlocha : GameBoard
    {
        public int NaPolickuPod(Postava postava)
        {
            return OnField(postava);
        }

        public int NaPolickuPred(Postava postava)
        {
            return NextField(postava);
        }
    }
}