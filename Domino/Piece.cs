using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Piece : IPiece
    {
        private int _leftVal;
        private int _rightVal;

        //constructor
        public Piece(int leftVal, int rightVal)
        {
            _leftVal = leftVal;
            _rightVal = rightVal;
           
        }

        public int LeftVal
        {
            get { return _leftVal; }
        }

        public int RightVal
        {
            get { return _rightVal; }
        }
       
    }


    
}
