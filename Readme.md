Angry birds C# learn platform
=========

This project is based on https://hourofcode.com, especially https://studio.code.org/hoc/1. This project helps children and not only children learn how to programing in their native languages (currently English and Czech. I'll be glad when you add more languages)

From a programming point of view it is not a good code and definitely it is not clean code or best practice. The code was created specifically to ease the work for the students as possible most readable syntax as can be.

**What can learn here: **
*Creation program, composing function calls
*Cycles (for, while, do while)
*Conditions
*Custom function

**The idea**
The students write to one file only. They made class derived from Game and implement IUserDefinedGame interface. But he does not have to know what it is. There is only two method LoadLevel and Start. There are twenty level wait for them, from simplest only go forward to "complex logic" with their defined method.

**How it look**
There is example of solve level 5

    public class OurGame : Game, IUserDefinedGame
    {
        public Level LoadLevel()
        {
            return new Level5();
        }

        public void Start()
        {
            AngryBird.Turn(To.Right);
            AngryBird.MoveForward();
            AngryBird.Turn(To.Left);
            for (int i = 1; i <= 3; i++)
            {
                AngryBird.MoveForward();
            }
            AngryBird.Turn(To.Left);
            AngryBird.MoveForward();
        }
    }

Level 20:

    public class OurGame : Game, IUserDefinedGame
    {
        public Level LoadLevel()
        {
            return new Level20();
        }

        public void Start()
        {
            while (GameBoard.OnField(AngryBird) != FieldType.Pig)
            {
                if (IsPathForward())
                {
                    AngryBird.MoveForward();
                }
                else
                {
                    if (IsPathRight())
                    {
                        AngryBird.Turn(To.Right);
                    }
                    else
                    {
                        AngryBird.Turn(To.Left);
                    }
                }
            }
        }

        bool IsPathForward()
        {
            var nextField = GameBoard.NextField(AngryBird);
            return nextField == FieldType.Path || nextField == FieldType.Pig;
        }

        bool IsPathLeft()
        {
            AngryBird.Turn(To.Left);
            var isThereWay = IsPathForward();
            AngryBird.Turn(To.Right);
            return isThereWay;
        }

        bool IsPathRight()
        {
            AngryBird.Turn(To.Right);
            var isThereWay = IsPathForward();
            AngryBird.Turn(To.Left);
            return isThereWay;
        }
    }

And the same level, but in another language in the Czech:

    public class NaseHra : Hra, IUzivatelemDefinovanaHra
    {
        public Level NactiLevel()
        {
            return new Level20();
        }

        public void PoSpusteni()
        {
            while (HraciPlocha.NaPolickuPod(AngryBird) != TypPolicka.Prase)
            {
                if (MuzeVpred())
                {
                    AngryBird.PosunoutVpred();
                }
                else
                {
                    if (JeCestaVPravo())
                    {
                        AngryBird.Otoc(Do.Prava);
                    }
                    else
                    {
                        AngryBird.Otoc(Do.Leva);
                    }
                }
            }
        }

        bool MuzeVpred()
        {
            var polickoPred = HraciPlocha.NaPolickuPred(AngryBird);
            return polickoPred == TypPolicka.Cesta || polickoPred == TypPolicka.Prase;
        }

        bool JeCestaVLevo()
        {
            AngryBird.Otoc(Do.Leva);
            var jeTamCesta = MuzeVpred();
            AngryBird.Otoc(Do.Prava);
            return jeTamCesta;
        }

        bool JeCestaVPravo()
        {
            AngryBird.Otoc(Do.Prava);
            var jeTamCesta = MuzeVpred();
            AngryBird.Otoc(Do.Leva);
            return jeTamCesta;
        }
    }

I know that's not a good idea to have a code in the national language, if it is not English :-). But we teach so many people from scratch, students of non-technical colleges, high school students, but also children under ten years of age and for them is not problem how to solve the maze or the code, but the English.

I'll be glad when applying expand, add additional levels or language. Especially when application help you teach or learn in the best programing language, the C#.