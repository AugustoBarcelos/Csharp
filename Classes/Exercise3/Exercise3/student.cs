using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class student
    {
        public string Name;
        public double grade1, grade2, grade3;

        public double finalgrade()
        {
            return grade1 + grade2 + grade3;
        }
        public bool Aproved()
        {
            if (finalgrade() > 59.4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double missing()
            {
            if (Aproved ())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - finalgrade();
            }
            }
        }

    }

