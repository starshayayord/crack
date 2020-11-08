using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Start
{
    public class Note
    {
        // Передан массив журналов (список слов в журнале через пробел) и текст записки (список слов через пробел)
        // Найти, могла ли быть записка склеена из слов вырезанных из какого-то одного журнала
        // Количество слов в журнале может быть значительно больше количества слов в записке
        // Вернуть номера журналов, из которых могла быть вырезана записка

        public class JournalState
        {
            public int Number { get; set; } // номер журнала

            public Dictionary<string, int> WordsInJournal { get; set; }

            public bool CanBeFromJournal { get; set; }
        }

        public static int[] IsFromJournal(string[] journals, string note)
        {
            var journalStates = new List<JournalState>();
            for (var i = 0; i < journals.Length; i++)
            {
                var journalState = new JournalState
                {
                    Number = i,
                    WordsInJournal = new Dictionary<string, int>(),
                    CanBeFromJournal = true
                };
                foreach (var word in journals[i].Split(' '))
                {
                    if (journalState.WordsInJournal.TryGetValue(word, out _))
                    {
                        journalState.WordsInJournal[word]++;
                    }
                    else
                    {
                        journalState.WordsInJournal[word] = 1;
                    }
                }

                journalStates.Add(journalState);
            }

            foreach (var word in note.Split(' '))
            {
                foreach (var journalState in journalStates)
                {
                    if (!journalState.CanBeFromJournal)
                    {
                        continue;
                    }

                    if (!journalState.WordsInJournal.TryGetValue(word, out var counterInJournal)
                        || counterInJournal == 0)
                    {
                        journalState.CanBeFromJournal = false;
                    }
                    else
                    {
                        journalState.WordsInJournal[word]--;
                    }
                }
            }

            return journalStates.Where(s => s.CanBeFromJournal).Select(s => s.Number).ToArray();
        }
    }
}
