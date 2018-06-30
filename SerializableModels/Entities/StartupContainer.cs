using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using Structure.Entities;

namespace SerializableModels.Entities
{
    [DataContract]
    public class StartupContainer : IStartupContainer
    {
        [NotNull] [DataMember] private readonly Board _board;
        [NotNull] [DataMember] private readonly List<Card> _cards;
        [NotNull] [DataMember] private readonly Dice _dice;
        [NotNull] [DataMember] private readonly List<Field> _fields;
        [NotNull] [DataMember] private readonly List<Question> _questions;

        public StartupContainer()
        {
            _board = new Board();
            _cards = new List<Card>();
            _dice = new Dice();
            _fields = new List<Field>();
            _questions = new List<Question>();
        }


        [NotNull]
        public IBoard Board => _board;

        [NotNull]
        public IReadOnlyList<ICard> Cards => new List<ICard>(_cards);

        [NotNull]
        public IDice Dice => _dice;

        [NotNull]
        public IReadOnlyList<IField> Fieldss => new List<IField>(_fields);

        [NotNull]
        public IReadOnlyList<IQuestion> Questions => new List<IQuestion>(_questions);
    }
}
