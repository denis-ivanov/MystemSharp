using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MystemSharp
{
    public class Lemma
    {
        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern IntPtr MystemLemmaText(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemLemmaTextLen(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern IntPtr MystemLemmaForm(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemLemmaFormLen(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern Quality MystemLemmaQuality(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern unsafe byte* MystemLemmaStemGram(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern unsafe byte** MystemLemmaFlexGram(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemLemmaFlexGramNum(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemLemmaFlexLen(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemLemmaRuleId(IntPtr lemma);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern IntPtr MystemGenerate(IntPtr lemma);
        
        private readonly IntPtr _pointer;
        
        internal Lemma(IntPtr pointer)
        {
            _pointer = pointer;
        }

        private int Length => MystemLemmaTextLen(_pointer);

        private int FormLength => MystemLemmaFormLen(_pointer);
        
        /// <summary>
        /// Текст леммы (для пользователя).
        /// </summary>
        public string Text
        {
            get
            {
                var text = MystemLemmaText(_pointer);
                return Marshal.PtrToStringUni(text, Length);
            }
        }

        /// <summary>
        /// Форма, приведённая к каноническому виду (диакритика, реникса...).
        /// </summary>
        public string Form
        {
            get
            {
                var form = MystemLemmaForm(_pointer);
                return Marshal.PtrToStringUni(form, FormLength);
            }
        }

        public Forms Forms => new Forms(MystemGenerate(_pointer));
        
        /// <summary>
        /// Указатель на грамматику при основе (не зависящую от формы).
        /// </summary>
        public unsafe List<Grammar> StemGram
        {
            get
            {
                var gramms = MystemLemmaStemGram(_pointer);
                return PointerToGrammars(gramms);
            }
        }
        
        public Quality Quality => MystemLemmaQuality(_pointer);

        /// <summary>
        /// Грамматики формы.
        /// </summary>
        public unsafe List<List<Grammar>> FlexGram
        {
            get
            {
                var num = MystemLemmaFlexGramNum(_pointer);
                var flexGram = MystemLemmaFlexGram(_pointer);
                var result = new List<List<Grammar>>();

                while (num-- != 0)
                {
                    var grams = PointerToGrammars(*flexGram++);
                    result.Add(grams);
                }

                return result;
            }
        }

        /// <summary>
        /// Длина окончания.
        /// </summary>
        public int FlexLength => MystemLemmaFlexLen(_pointer);

        public int RuleId => MystemLemmaRuleId(_pointer);

        public override string ToString() => Text;

        internal static unsafe List<Grammar> PointerToGrammars(byte* pointer)
        {
            var result = new List<Grammar>();

            while (pointer != (byte*)0 && *pointer != (byte)'\0')
            {
                result.Add((Grammar)(*pointer));
                pointer++;
            }
            
            return result;
        }
    }
}
