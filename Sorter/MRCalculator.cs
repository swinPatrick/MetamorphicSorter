using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Transactions;

namespace Assign2
{
    class MRCalculator
    {
        private TestCases TC;
        private int total_cases;
        private List<List<int>> SI, SO;


        public string CalculateMRResults(SorterProper sp)
        {
            TC = new TestCases();
            SI = TC.GetSI;
            total_cases = SI.Count;
            SO = TC.GetSO;
            string mr1_results = MR1(sp);
            string mr2_results = MR2(sp);
            return mr1_results + '\n' + mr2_results;
        }

        //returns a string describing results from MR1
        private string MR1(SorterProper sp)
        {
            List<List<int>> FI, FO;
            //compare original test cases test_cases to new sorted cases tc by applying MR
            // if FI is constructed as a permutation of the elecments in SI, then FO = SO
            // for simplicity, in this case we will reverse the order that elements appear in
            FI = new List<List<int>>();
            //FI = SI.AsReadOnly();
            string output = "";
            for (int caseNum = 0; caseNum < SI.Count; caseNum++)
            {
                FI.Add(SI[caseNum]);
                FI[caseNum].Reverse();
            }

            // now, FO should = SO
            FO = sp.Sort(FI);

            List<int> differences = Differences(FO, SO);
            output += "\nMR1 FI=Permutation(SI), FO=SO:";
            output += MREffectiveness(differences);
            return output;
        }

        private string MR2(SorterProper sp)
        {
            List<List<int>> FI, FO;
            //compare original test cases test_cases to new sorted cases tc by applying MR
            // if FI is defined as SI+[x], where x is smaller than the first element of SO, then FO=SO
            FI = new List<List<int>>();
            FI.AddRange(SI);
            for(int i = 0; i < FI.Count; i++) { FI[i].Add(SO[i][0] - 1); }

            // now, FO should = SO
            FO = sp.Sort(FI);
            List<List<int>> tSO = new List<List<int>>();
            tSO.AddRange(SO);
            for(int i = 0; i < tSO.Count; i++) { tSO[i].Insert(0, SO[i][0] - 1); }
            List<int> differences = Differences(FO, SO);
            string output = "\nMR2 FI=SI+[x], FO=SO:";
            output += MREffectiveness(differences);
            return output;
        }

        private List<int> Differences(List<List<int>> fo, List<List<int>> so)
        {
            List<int> differences = new List<int>();
            differences.Clear();
            if (fo.SequenceEqual(so))
            {
                return differences;
            }
            for (int i = 0; i < fo.Count; i++)
            {
                if(fo[i].SequenceEqual(so[i]))
                    continue;
                differences.Add(i);
            }
            return differences;
        }

        private string ListAsText(string listname, List<int> list)
        {
            string output = "\n" + listname + ": ";
            list.ForEach(delegate (int i) { output += i + " "; });
            return output;
        }

        private string MREffectiveness(List<int> dif)
        {
            string o = ListAsText("\tDifferences", dif);
            o += "\n\tRatio of Violations = " + dif.Count;
            o += "/" + total_cases;
            o += " = " + (100 * dif.Count / total_cases) + "%";
            return o;
        }

        private string CompareValuesAsText(List<List<int>> fi, List<List<int>> fo)
        {
            string o = "";
            for(int i = 0; i < fi.Count; i++)
            {
                o += ListAsText("FI[" + i + "]", fi[i]);
                o += ListAsText("FO[" + i + "]", fo[i]);
                o += ListAsText("SO[" + i + "]", SO[i]);
                o += "\n--";
            }
            return o;
        }
    }
}
