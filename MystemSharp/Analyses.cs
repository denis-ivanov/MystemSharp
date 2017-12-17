using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MystemSharp
{
    public class Analyses : IEnumerable<Lemma>
    {
        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern IntPtr MystemAnalyze(string word, int len);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern void MystemDeleteAnalyses(IntPtr analyses);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemAnalysesCount(IntPtr analyses);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern IntPtr MystemLemma(IntPtr analyses, int index);

        private readonly IntPtr _pointer;
        
        public Analyses(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            _pointer = MystemAnalyze(word, word.Length);
        }

        ~Analyses()
        {
            MystemDeleteAnalyses(_pointer);
        }
        
        public IEnumerator<Lemma> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => MystemAnalysesCount(_pointer);

        public Lemma this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                
                return new Lemma(MystemLemma(_pointer, index));
            }
        }
    }
}
