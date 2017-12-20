using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MystemSharp
{
    public class Forms : IReadOnlyList<Form>
    {
        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern void MystemDeleteForms(IntPtr forms);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern int MystemFormsCount(IntPtr forms);

        [DllImport("mystem_c_binding", CharSet = CharSet.Unicode)]
        private static extern IntPtr MystemForm(IntPtr forms, int i);
        
        private readonly IntPtr _pointer;

        internal Forms(IntPtr pointer)
        {
            _pointer = pointer;
        }

        public IEnumerator<Form> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        ~Forms()
        {
            MystemDeleteForms(_pointer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Form this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                
                return new Form(MystemForm(_pointer, index));
            }
        }
        
        public int Count => MystemFormsCount(_pointer);
    }
}
