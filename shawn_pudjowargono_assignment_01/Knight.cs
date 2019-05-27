using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Knight
    {
        public int row { get; set; }
        public int column { get; set; }

        public ArrayList accessible_tiles = new ArrayList();

        public Knight()
        {
            row = 3;
            column = 4;
        }

        public void update_accessible_tiles()
        {
            accessible_tiles = new ArrayList();



            
            //-1 -2
            //-1 +2
            //+1 -2
            //+1 +2
            //+2 -1
            //+2 +1
            //-2 -1
            //-2 +1
        }

    }
}
