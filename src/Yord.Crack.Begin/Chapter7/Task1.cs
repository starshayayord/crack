using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter7
{
    // Структура данных для колоды карт для Блек Джека
    // Туз мб 1 или 11, карты с картинкой = 10, иначе по значению
    public class Task1
    {
        public enum Suit
        {
            Club,
            Diamond,
            Heart,
            Spade
        }

        
        public abstract class Card
        {
            // 11 - валет, 12 - дама, 13, король, 1 - туз
            private const int MinCardValue = 1;
            private const int MaxCardValue = 13;
            
            public int FaceValue { get; }

            public Suit Suit { get; }

            public bool IsAvailable { get; private set; }

            public Card(int faceValue, Suit suit)
            {
                FaceValue = faceValue;
                Suit = suit;
                IsAvailable = true;
            }

            public bool IsAce => FaceValue == 1;
            public bool IsFaceCard => FaceValue >= 11 && FaceValue <= 13;
                
            public void Use()
            {
                IsAvailable = false;
            }
            
            public void Return()
            {
                IsAvailable = true;
            }
        }

        public class Hand<T> where T : Card
        {
            protected List<T> Cards;

            public Hand(T[] cards)
            {
                Cards = cards.ToList();
            }

            public int CardsInHand => Cards.Count;
            public void AddCard(T card)
            {
                Cards.Add(card);
            }
        }

        public class BlackJackHand : Hand<Card>
        {
            public const int MinAceValue = 1;
            public const int MaxAceValue = 11;
            public const int FaceValue = 10;
            public const int MaxBJScore = 21;
            
            public BlackJackHand(Card[] cards) : base(cards)
            {
            }

            public int Score()
            {
                var scores = GetPossibleScores();
                if (scores.Count == 0) return 0;
                var minOver = int.MaxValue;
                var maxUnder = 0;
                foreach (var score in scores)
                {
                    if (score > MaxBJScore)
                    {
                        if (minOver > score)
                        {
                            minOver = score;
                        }
                    }
                    else
                    {
                        if (maxUnder < score)
                        {
                            maxUnder = score;
                        }
                    }
                }

                return maxUnder == 0 ? maxUnder : minOver;
            }
            
            private List<int> GetPossibleScores()
            {
                var possibleScores = new List<int>();
                foreach (var card in Cards)
                {
                    if (card.IsAce)
                    {
                        if (possibleScores.Count == 0)
                        {
                            possibleScores.Add(MinAceValue);
                            possibleScores.Add(MaxAceValue);
                        }
                        else
                        {
                            var additionalScores = new List<int>();
                            for (var i = 0; i < possibleScores.Count; i++)
                            {
                                additionalScores.Add(possibleScores[i] + MaxAceValue);
                                possibleScores[i] += MinAceValue;
                            }
                            possibleScores.AddRange(additionalScores);
                        }
                    }
                    else
                    {
                        var value = card.IsFaceCard ? FaceValue : card.FaceValue;
                        if (possibleScores.Count == 0)
                        {
                            possibleScores.Add(value);
                        }
                        else
                        {
                            for (var i = 0; i < possibleScores.Count; i++)
                            {
                                possibleScores[i] += value;
                            }
                        }
                    }
                }

                return possibleScores;
            }
        }

        
        

        public class Deck<T> where T : Card
        {
            private static readonly Random _random = new Random();
            private int _dealtCardIndex;
            private T[] Cards;

            public Deck(T[] cards)
            {
                Cards = cards;
            }

            public int LeftInDeck => Cards.Length - _dealtCardIndex;
            public T GetNextCard()
            {
                while (_dealtCardIndex < Cards.Length)
                {
                    var card = Cards[_dealtCardIndex];
                    _dealtCardIndex++;
                    if (card.IsAvailable)
                    {
                        card.Use();
                        return card;
                    }
                }

                throw new IndexOutOfRangeException();
            }

            public void Shuffle()
            {
                _dealtCardIndex = 0;
                for (var i = Cards.Length - 1; i >= 0; i--)
                {
                    var swapIndex = _random.Next(i + 1);
                    var c1 = Cards[swapIndex];
                    Cards[swapIndex] = Cards[i];
                    Cards[i] = c1;
                }
            }
        }
    }
}
