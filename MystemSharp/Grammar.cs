namespace MystemSharp
{
    public enum Grammar
    {
        Invalid = 0,

        Before = 126,

        /*--------------------*/
        /// <summary>
        ///     POSTP
        /// </summary>
        Postposition,

        First = Postposition,

        /// <summary>
        ///     A / Nomenus.
        /// </summary>
        Adjective,

        /// <summary>
        ///     ADV.
        /// </summary>
        Adverb,

        /// <summary>
        ///     COM(P).
        /// </summary>
        Composite,

        /// <summary>
        ///     CONJ.
        /// </summary>
        Conjunction,

        /// <summary>
        ///     INTJ.
        /// </summary>
        Interjunction,

        /// <summary>
        ///     NUM.
        /// </summary>
        Numeral,

        /// <summary>
        ///     PCL.
        /// </summary>
        Particle,

        /// <summary>
        ///     PRE(P).
        /// </summary>
        Preposition,

        /// <summary>
        ///     S.
        /// </summary>
        Substantive,

        /// <summary>
        ///     V.
        /// </summary>
        Verb,

        /// <summary>
        ///     ANUM.
        /// </summary>
        AdjNumeral,

        /// <summary>
        ///     APRO.
        /// </summary>
        AdjPronoun,

        /// <summary>
        ///     ADVPRO.
        /// </summary>
        AdvPronoun,

        /// <summary>
        ///     SPRO.
        /// </summary>
        SubstPronoun,

        /// <summary>
        ///     Артикли.
        /// </summary>
        Article,

        /// <summary>
        ///     Части идиом (прежде всего иностр. слов).
        /// </summary>
        PartOfIdiom,

        LastPartOfSpeech = PartOfIdiom,

        /// <summary>
        ///     Зарезервировано / особые пометы.
        /// </summary>
        Reserved,

        /// <summary>
        ///     Сокращения.
        /// </summary>
        Abbreviation,

        /// <summary>
        ///     Чередование в корне (или супплетивизм).
        /// </summary>
        IrregularStem,

        /// <summary>
        ///     Разговорная форма.
        /// </summary>
        Informal,

        /// <summary>
        ///     Искаженная форма.
        /// </summary>
        Distort,

        /// <summary>
        ///     Стяжённая форма (фр. q' и т.п.).
        /// </summary>
        Contracted,

        /// <summary>
        ///     Обсц.
        /// </summary>
        Obscene,

        /// <summary>
        ///     Редк.
        /// </summary>
        Rare,

        /// <summary>
        ///     Затр.
        /// </summary>
        Awkward,

        /// <summary>
        ///     Устар.
        /// </summary>
        Obsolete,

        /// <summary>
        ///     Адъект.
        /// </summary>
        SubstAdjective,

        /// <summary>
        ///     Имя.
        /// </summary>
        FirstName,

        /// <summary>
        ///     Фам.
        /// </summary>
        Surname,

        /// <summary>
        ///     Отч.
        /// </summary>
        Patr,

        /// <summary>
        ///     Гео.
        /// </summary>
        Geo,

        /// <summary>
        ///     Собств.
        /// </summary>
        Proper,

        /// <summary>
        ///     Наст / Tempus.
        /// </summary>
        Present,

        /// <summary>
        ///     Непрош.
        /// </summary>
        Notpast,

        /// <summary>
        ///     Прош.
        /// </summary>
        Past,

        /// <summary>
        ///     Буд. время (фр., ит.).
        /// </summary>
        Future,

        /// <summary>
        ///     Фр. passe simple, ит. passato remoto.
        /// </summary>
        Past2,

        /// <summary>
        ///     Именительный падеж.
        /// </summary>
        Nominative,

        /// <summary>
        ///     Родительный падеж.
        /// </summary>
        Genitive,

        /// <summary>
        ///     Дательный падеж.
        /// </summary>
        Dative,

        /// <summary>
        ///     Винительный падеж.
        /// </summary>
        Accusative,

        /// <summary>
        ///     Творительный падеж.
        /// </summary>
        Instrumental,

        /// <summary>
        ///     Пр.
        /// </summary>
        Ablative,

        /// <summary>
        ///     Парт(вин2).
        /// </summary>
        Partitive,

        /// <summary>
        ///     Местн(пр2).
        /// </summary>
        Locative,

        /// <summary>
        ///     Звательный.
        /// </summary>
        Vocative,

        /// <summary>
        ///     Ед / Numerus.
        /// </summary>
        Singular,

        /// <summary>
        ///     Мн.
        /// </summary>
        Plural,

        /// <summary>
        ///     Деепр // Modus.
        /// </summary>
        Gerund,

        /// <summary>
        ///     Инф.
        /// </summary>
        Infinitive,

        /// <summary>
        ///     Прич.
        /// </summary>
        Participle,

        /// <summary>
        ///     Изъяв.
        /// </summary>
        Indicative,

        /// <summary>
        ///     Пов.
        /// </summary>
        Imperative,

        /// <summary>
        ///     Усл. наклонение (фр., ит.).
        /// </summary>
        Conditional,

        /// <summary>
        ///     Сослаг. накл. (фр., ит.).
        /// </summary>
        Subjunctive,

        /// <summary>
        ///     Кр / Gradus.
        /// </summary>
        Short,

        /// <summary>
        ///     Полн.
        /// </summary>
        Full,

        /// <summary>
        ///     Прев.
        /// </summary>
        Superlative,

        /// <summary>
        ///     Срав.
        /// </summary>
        Comparative,

        /// <summary>
        ///     Притяж.
        /// </summary>
        Possessive,

        /// <summary>
        ///     1-л / Personae.
        /// </summary>
        Person1,

        /// <summary>
        ///     2-л.
        /// </summary>
        Person2,

        /// <summary>
        ///     3-л.
        /// </summary>
        Person3,

        /// <summary>
        ///     Жен / Gender (genus).
        /// </summary>
        Feminine,

        /// <summary>
        ///     Муж.
        /// </summary>
        Masculine,

        /// <summary>
        ///     Сред.
        /// </summary>
        Neuter,

        /// <summary>
        ///     Мж.
        /// </summary>
        MasFem,

        /// <summary>
        ///     Сов / Perfectum-imperfectum (Accept).
        /// </summary>
        Perfect,

        /// <summary>
        ///     Несов.
        /// </summary>
        Imperfect,

        /// <summary>
        ///     Страд / Voice (Genus).
        /// </summary>
        Passive,

        /// <summary>
        ///     Действ.
        /// </summary>
        Active,

        /// <summary>
        ///     Возвратные.
        /// </summary>
        Reflexive,

        /// <summary>
        ///     Безличные.
        /// </summary>
        Impersonal,

        /// <summary>
        ///     Од / Animated.
        /// </summary>
        Animated,

        /// <summary>
        ///     Неод.
        /// </summary>
        Inanimated,

        /// <summary>
        ///     Прдк.
        /// </summary>
        Praedic,

        /// <summary>
        ///     Вводн.
        /// </summary>
        Parenth,

        /// <summary>
        ///     Пе / transitivity.
        /// </summary>
        Transitive,

        /// <summary>
        ///     Нп.
        /// </summary>
        Intransitive,

        /// <summary>
        ///     Опред. члены / definiteness.
        /// </summary>
        Definite,

        /// <summary>
        ///     Неопред. члены.
        /// </summary>
        Indefinite,

        /// <summary>
        ///     Сочинит. (для союзов).
        /// </summary>
        SimConj,

        /// <summary>
        ///     Подчинит. (для союзов).
        /// </summary>
        SubConj,

        /// <summary>
        ///     Местоимение-союз ("я знаю, _что_ вы сделали прошлым летом").
        /// </summary>
        PronounConj,

        /// <summary>
        ///     Вторая зависимая часть парных союзов - "если ... _то_ ... ", "как ... _так_ и ...".
        /// </summary>
        CorrelateConj,

        /// <summary>
        ///     Вспомогательный глагол в аналитической форме ("_будем_ думать").
        /// </summary>
        AuxVerb,

        /* Additional grammemes for Turkish and Armenian */
        Dual,

        Poss1p,

        Poss1pSg,

        Poss1pPl,

        Poss2p,

        Poss2pSg,

        Poss2pPl,

        Poss3p,

        Poss3pSg,

        Poss3pPl,

        Predic1pSg,

        Predic1pPl,

        Predic2pSg,

        Predic2pPl,

        Predic3pSg,

        Predic3pPl,

        Elative,

        DerivedAdjective,

        Evidential,

        Negated,

        Potential,

        Medial,

        Human,

        AssocPlural,

        Optative,

        Converb,

        Simultaneous,

        Connegative,

        Resultative,

        Subjective,

        /// <summary>
        ///     Счётная форма.
        /// </summary>
        Count,

        GoodForm,

        PredicPoss,

        Intention,

        Honorific,

        Equative,

        Predic,

        Obligatory,

        Max,

        Max2 = Max
    }
}