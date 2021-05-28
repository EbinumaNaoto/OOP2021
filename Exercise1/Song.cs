using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {

    class Song {
        /*
        //フィールド
        private string title;       //歌のタイトル
        private string artistName;  //アーティスト名
        private int length;         //演奏時間、単位は秒
        */

        //プロパティ
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        //引数付きコンストラクタ
        public Song(string title,string artistName,int length) {
            this.Title = title;
            this.ArtistName = artistName;
            this.Length = length;
        }
    }
}
