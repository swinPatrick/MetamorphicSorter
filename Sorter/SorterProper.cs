using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Assign2
{
    public class SorterProper
    {
        public enum Type { Working, Mutant1, Mutant2}
        private Type program_type;
        readonly TestCases test_cases;

        public SorterProper(Type t)
        {
            test_cases = new TestCases();

            program_type = t;
        }

        public List<List<int>> Sort(List<List<int>> listolists)
        {
            List<List<int>> tmplists = new List<List<int>>();
            tmplists.Clear();
            tmplists.AddRange(listolists);
            for(int i = 0; i< tmplists.Count; i++)
            {
                tmplists[i] = Sort(tmplists[i]);
            }
            return tmplists;
        }
        public List<int> Sort(List<int> list)
        {
            List<int> tmp = new List<int>();
            tmp.AddRange(list);
            tmp = GetUniqueValues(tmp);
            tmp = SortCases(tmp);
            return tmp;
        }

        private List<int> GetUniqueValues(List<int> tcase)
        {
            List<int> unique_values = new List<int>();
            switch (program_type)
            {
                case Type.Mutant1:
                    unique_values.Clear();
                    for (int j = 1; j < tcase.Count; j++)
                    {
                        if (!unique_values.Contains(tcase[j]))
                            unique_values.Add(tcase[j]);
                    }
                    return unique_values;

                case Type.Mutant2:
                case Type.Working:
                default:
                    unique_values.Clear();
                    for (int j = 0; j < tcase.Count; j++)
                    {
                        if (!unique_values.Contains(tcase[j]))
                            unique_values.Add(tcase[j]);
                    }
                    return unique_values;
            }
        }

        private List<int> SortCases(List<int> list)
        {
            List<int> tmplist = new List<int>();
            tmplist.Clear();
            tmplist.AddRange(list);
            switch (program_type)
            {
                case Type.Mutant2:
                    tmplist.Sort(1, tmplist.Count-1, null);
                    break;

                case Type.Mutant1:
                case Type.Working:
                default:
                    tmplist.Sort(0, tmplist.Count, null);
                    break;
            }
            return tmplist;
        }
    }
}
