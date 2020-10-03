using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{
    public class TestCases
    {
        public List<List<int>> GetSI { get; } = new List<List<int>>() {
            new List<int>() { 0, -3, -10, -8, 2, 0, -14, -10, -10, 5, 5, 20, 3, 2, -8, 9, 4, 19, 17, 19 }, // a non-empty list in no order (with duplicates)
            new List<int>() { -4, 14, -6, 3, 18, 5, -10, 15, 17, 9, 13  }, // a non-empty list in no order (without duplicates)
            new List<int>() { -16, -16, -15, -15, -14, -7, -5, -5, -1, 1, 2, 2, 10, 15, 15, 21, 21 }, // a non-empty list in ascending order (with duplicates)
            new List<int>() { -19, -18, -15, -10, 3, 5, 8, 9, 12, 16, 17 }, // a non-empty list in ascending order (without duplicates)
            new List<int>() { 19, 19, 14, 3, 3, 2, 1, -2, -2, -8, -11, -13, -13, -14, -18 }, // a non-empty list in descending order (with duplicates)
            new List<int>() { 20, 18, 16, 9, 6, 4, 2, 0, -8, -9, -14 }, // a non-empty list in descending order (without duplicates)

            new List<int>() { 2, 16, 20, 10, 4, 17, 8, 29, 6, 25, 3, 30, 15, 23, 13 }, // a non-empty, all positive list in no order, without duplicates
            new List<int>() { 6, 4, 20, 14, 24, 31, 7, 13, 29, 26, 23, 15, 9, 1, 22, 14, 29, 15, 1 }, // a non-empty, all positive list in no order, with duplicates
            new List<int>() { 1, 5, 7, 8, 12, 17, 19, 21, 23, 26, 27, 30, 31 }, // a non-empty, all positive list in ascending order, without duplicates
            new List<int>() { 5, 8, 8, 8, 10, 13, 15, 17, 17, 18, 18, 24, 25, 26, 27, 27, 27, 28, 29, 29 }, // a non-empty, all positive list in ascending order, with duplicates
            new List<int>() { 31, 30, 27, 26, 23, 22, 18, 17, 10 }, // a non-empty, all positive list in descending order, without duplicates
            new List<int>() { 21, 21, 21, 20, 17, 16, 16, 14, 9, 6, 5, 5, 5, 1, 1 }, // a non-empty, all positive list in descending order, with duplicates

            new List<int>() { -22, -10, -26, -30, -5, -16, -3, -8, -14, -6, -15, -23, -29, -19, -24 }, // a non-empty, all negative list in no order, without duplicates
            new List<int>() { -18, -9, -21, -20, -22, -33, -16, -25, -29, -4, -3, -1, -9, -22, -18, -29 }, // a non-empty, all negative list in no order, with duplicates
            new List<int>() { -32, -30, -29, -28, -25, -23, -22, -21, -20, -18, -17, -14, -12, -11, -9, -8, -1 }, // a non-empty, all negative list in ascending order, without duplicates
            new List<int>() { -27, -27, -27, -23, -21, -20, -20, -19, -16, -14, -12, -10, -8, -8, -8 -6, -3 }, // a non-empty, all negative list in ascending order, with duplicates
            new List<int>() { -3, -4, -9, -10, -12, -14, -16, -19, -20, -21 }, // a non-empty, all negative list in descending order, without duplicates
            new List<int>() { -9, -12, -15, -17, -21, -22, -28, -31, -32, -15, -31, -9, -15, -28 }, // a non-empty, all negative list in descending order, with duplicates
        };

        public List<List<int>> GetSO { get; } = new List<List<int>>()
        {
            new List<int>() { -14, -10, -8, -3, 0, 2, 3, 4, 5, 9, 17, 19, 20 }, //both, no, with
            new List<int>() { -10, -6, -4, 3, 5, 9, 13, 14, 15, 17, 18 }, //both, no, without
            new List<int>() { -16, -15, -14, -7, -5, -1, 1, 2, 10, 15, 21 }, //both, ascend, with
            new List<int>() { -19, -18, -15, -10, 3, 5, 8, 9, 12, 16, 17 }, //both, ascend, without
            new List<int>() { -18, -14, -13, -11, -8, -2, 1, 2, 3, 14, 19 }, //both, desc, with
            new List<int>() { -14, -9, -8, 0, 2, 4, 6, 9, 16, 18, 20 }, //both, desc, without

            new List<int>() { 2, 3, 4, 6, 8, 10, 13, 15, 16, 17, 20, 23, 25, 29, 30 },
            new List<int>() { 1, 4, 6, 7, 9, 13, 14, 15, 20, 22, 23, 24, 26, 29, 31 },
            new List<int>() { 1, 5, 7, 8, 12, 17, 19, 21, 23, 26, 27, 30, 31 },
            new List<int>() { 5, 8, 10, 13, 15, 17, 18, 24, 25, 26, 27, 28, 29 },
            new List<int>() { 10, 17, 18, 22, 23, 26, 27, 30, 31 },
            new List<int>() { 1, 5, 6, 9, 14, 16, 17, 20, 21 },

            new List<int>() { -30, -29, -26, -24, -23, -22, -19, -16, -15, -14, -10, -8, -6, -5, -3 }, //neg, no, wihout
            new List<int>() { -33, -29, -25, -22, -21, -20, -18, -16, -9, -4, -3, -1 }, //neg, no, with
            new List<int>() { -32, -30, -29, -28, -25, -23, -22, -21, -20, -18, -17, -14, -12, -11, -9, -8, -1 }, //neg, asc, without
            new List<int>() { -27, -23, -21, -20, -19, -16, -14, -12, -10, -8, -3 }, //neg, asc, with
            new List<int>() { -21, -20, -19, -16, -14, -12, -10, -9, -4, -3 }, //neg, desc, without
            new List<int>() { -32, -31, -28, -22, -21, -17, -15, -12, -9 }, //neg, desc, with
        };
    }
}