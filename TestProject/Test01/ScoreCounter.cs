using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //メソッドの概要： 学生データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            
            var scores = new List<Student>(); //学生データを入れるリストオブジェクトの生成
            var lines = File.ReadAllLines(filePath); //ファイルを全て読み込み、string配列へ格納

            foreach (var line in lines) {
                var items = line.Split(','); //一行ずつ取り出し、"学生の名前","科目名","点数"に分けて、string配列へ格納
                var student = new Student { //studentオブジェクトの生成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(student); //studentオブジェクトをリストへ格納
            }
            return scores;
        }

        //メソッドの概要： 科目別の点数を集計
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new Dictionary<string, int>(); //科目別に集計した点数を格納するDictionary生成

            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score; //科目名が同じsocreを集計しながら、dictへ格納
                } else {
                    dict[student.Subject] = student.Score; //科目名が違った場合、dictの新たな科目名に、scoreを格納
                }
            }
            return dict;
        }
    }
}
