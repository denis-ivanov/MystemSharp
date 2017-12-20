using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MystemSharp
{
    public class Form
    {
        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern IntPtr MystemFormText(IntPtr form);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemFormTextLen(IntPtr form);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern unsafe byte* MystemFormStemGram(IntPtr form);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern unsafe byte** MystemFormFlexGram(IntPtr form);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemFormFlexGramNum(IntPtr form);
        
        private readonly IntPtr _pointer;

        public Form(IntPtr pointer)
        {
            _pointer = pointer;
        }

        private int Length => MystemFormTextLen(_pointer);

        public string Text
        {
            get
            {
                var text = MystemFormText(_pointer);
                return Marshal.PtrToStringUni(text, Length);
            }
        }

        public unsafe List<Grammar> StemGram => 
            Lemma.PointerToGrammars(MystemFormStemGram(_pointer));

        public unsafe List<List<Grammar>> FlexGram
        {
            get
            {
                var num = MystemFormFlexGramNum(_pointer);
                var flexGram = MystemFormFlexGram(_pointer);
                var result = new List<List<Grammar>>();

                while (num-- != 0)
                {
                    var grams = Lemma.PointerToGrammars(*flexGram++);
                    result.Add(grams);
                }

                return result;
            }
        }

        public override string ToString() => Text;
    }
}
