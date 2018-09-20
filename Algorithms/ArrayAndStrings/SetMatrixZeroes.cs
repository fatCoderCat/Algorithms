using System.Collections.Generic;
using System.Linq;

namespace Algorithms.ArrayAndStrings
{
    public class SetMatrixZeroes
    {
        private List<int> _iZeros = new List<int>();
        private List<int> _jZeros = new List<int>();
        
        public void SetZeroes(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        _iZeros.Add(i);
                        _jZeros.Add(j);
                    }
                }
            }
            
            _iZeros = _iZeros.Distinct().ToList();
            _jZeros = _jZeros.Distinct().ToList();
                
            foreach (var iZero in _iZeros)
            {
                for (int z = 0; z < matrix.GetLength(1); z++)
                {
                    matrix[iZero, z] = 0;
                }
            }
                
            foreach (var jZero in _jZeros)
            {
                for (int z = 0; z < matrix.GetLength(0); z++)
                {
                    matrix[z, jZero] = 0;
                }
            }
        }
    }
}