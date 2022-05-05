using System;
using System.Collections.Generic;
using System.Text;

namespace Question3
{
    public class Humanoid
    {

        private string skill;

        public Humanoid()
        {
            skill = "no skill defined";
        }

        public Humanoid(Skill _skill)
        {
            skill = _skill.Name;
        }

        public string ShowSkill()
        {
            return skill;
        }



    }
}
