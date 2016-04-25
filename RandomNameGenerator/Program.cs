using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGenerator {
    class Program {
        static void Main(string[] args)
        {
            Gender userGender = Gender.Neutral;
            if (args.Length > 0)
            {
                if (args[0].ToLower().StartsWith("m"))
                {
                    userGender = Gender.Male;
                }
                else if (args[0].StartsWith("f"))
                {
                    userGender = Gender.Female;
                }
                else
                {
                    userGender = Gender.Neutral;
                }
            }


            MakePeople mypeople = new MakePeople(userGender);
        }
    }
}
