using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter7
{
    // Спроектировать музыкальный автомат (работает бесплатно) (Jukebox)
    // Функции автомата:
    // Создание списка воспроизведения
    // Выбор диска 
    // Выбор композиции
    // Постановка композиции в очередь
    // Выбор следующей композиции из плейлиста
    // Функции для пользователя:
    // Добавление композиции в очередь
    // Удаление их из очереди
    // Просмотр инфо на экране

    //Компоненты системы
    // Музыкальный автомат (Jukebox)
    // Привод для проигрывания дисков (CdPlayer)
    // Композиция (Song)
    // Исполнитель (Artist)
    // Список воспроизведения (Playlist)
    // Экран (Display)

    public class Task3
    {
        public class Jukebox
        {
            private CdPlayer _cdPlayer;
            private User _user;
            private HashSet<Cd> _cdCollection;
            private SongSelector _ts;

            public Jukebox(CdPlayer cdPlayer, User user, HashSet<Cd> cdCollection, SongSelector ts)
            {
                _cdPlayer = cdPlayer;
                _user = user;
                _cdCollection = cdCollection;
                _ts = ts;
            }

            public Song CurrentSong => _ts.GetCurrentSong();

            public void SetUser(User u)
            {
                _user = u;
            }
        }

        // идентификатор, испольнитель, композиции
        public class Cd
        {
        }

        // может воспроизводить один диск в один момент
        public class CdPlayer
        {
            public Playlist Playlist
            {
                get => Playlist;
                set => Playlist = value;
            }

            public Cd Cd
            {
                get => Cd;
                set => Cd = value;
            }

            public CdPlayer(Cd c, Playlist p)
            {
                Cd = c;
                Playlist = p;
            }

            public CdPlayer(Playlist p)
            {
                Playlist = p;
            }

            public CdPlayer(Cd c)
            {
                Cd = c;
            }

            public void PlaySong(Song s)
            {
            }
        }

        // (обертка некоторой очереди воспроизведения)
        public class Playlist
        {
            private Song _song;
            private Queue<Song> _queue;

            public Playlist(Song s, Queue<Song> queue)
            {
                //...
            }

            public Song GetNextToPlay()
            {
                return _queue.Peek();
            }

            public void QueueUpSong(Song s)
            {
                _queue.Enqueue(s);
            }
        }

        public class User
        {
            private long Id { get; }

            public User(long id)
            {
                Id = id;
            }
        }

        public class SongSelector
        {
            public Song GetCurrentSong()
            {
                throw new System.NotImplementedException();
            }
        }

        // идентификатор, cd, название, длина...
        public class Song
        {
        }
    }
}
