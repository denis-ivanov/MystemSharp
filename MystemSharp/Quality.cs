using System;

namespace MystemSharp
{
    [Flags]
    public enum Quality
    {
        /// <summary>
        ///     Слово из словаря.
        /// </summary>
        Dictionary = 0x00000000,

        /// <summary>
        ///     Не словарное.
        /// </summary>
        Bastard = 0x00000001,

        /// <summary>
        ///     Из "быстрого словаря".
        /// </summary>
        Sob = 0x00000002,

        /// <summary>
        ///     Словарное + стандартный префикс (авто- мото- кино- фото-)
        ///     всегда в компании с <see cref="Bastard" /> или <see cref="Sob" />.
        /// </summary>
        Prefixoid = 0x00000004,

        /// <summary>
        ///     Непонятный набор букв, но проходящий в алфавит.
        /// </summary>
        Foundling = 0x00000008,

        /// <summary>
        ///     Доп. флаг.: "плохая лемма" при наличии "хорошей" альтернативы ("махать" по форме "маша").
        /// </summary>
        BadRequest = 0x00000010,

        /// <summary>
        ///     Переведено с английского.
        /// </summary>
        FromEnglish = 0x00010000,

        /// <summary>
        ///     Переведено на английский.
        /// </summary>
        ToEnglish = 0x00020000,

        /// <summary>
        ///     "Переведено" с транслита.
        /// </summary>
        Untranslit = 0x00040000,

        /// <summary>
        ///     Текст леммы был перезаписан.
        /// </summary>
        Overrode = 0x00100000,

        /// <summary>
        ///     Слово из фикс-листа.
        /// </summary>
        Fix = 0x01000000
    }
}
