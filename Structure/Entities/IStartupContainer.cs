using System.Collections.Generic;

namespace Structure.Entities
{
    public interface IStartupContainer
    {
        IBoard Board { get; }

        IReadOnlyList<ICard> Cards { get; }

        IDice Dice { get; }

        IReadOnlyList<IField> Fieldss { get; }

        IReadOnlyList<IQuestion> Questions { get; }
    }
}