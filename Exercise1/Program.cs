using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {

        static void Main(string[] args) {
            //2.1.3
            var songs = new Song[] {
                new Song("光、再考", "amazarashi", 339),
                new Song("つじつま合わせに生まれた僕等", "amazarashi", 340),
                new Song("少年少女", "amazarashi", 345)
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine($"アーティスト名: {song.ArtistName}");
                Console.WriteLine($"タイトル: {song.Title}");
                Console.WriteLine(@"演奏時間: {0:m\:ss}",TimeSpan.FromSeconds(song.Length));
                Console.WriteLine();
            }
        }
        /*
            @"{0}, {1} {2:m\:ss}"について
            {}の中で、:は特別な意味を持っている。そのため、:を、文字':'として表示させるために、
            \:としている。なお、\:をエスケープシーケンスと認識させないように、@を先頭に付加し、
            逐語的リテラル文字列にしている。
        */
    }
}
