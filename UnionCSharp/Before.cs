using System;
using System.Collections.Generic;
using System.Text;

namespace UnionCSharp
{
    public class Before
    {
        public string Name { get; set; }
        
        public void GetUser()
        {
            //インスタンス生成の糖衣構文
            //C# 9.0以降で導入された、オブジェクト初期化子の糖衣構文を使用して、インスタンスを生成することができます。
            //以下コードは同じ型の別オブジェクトを作成
            var user1 = new Before { Name = "hoge" };
            var user2 = new Before { Name = "geho" };
        }

    }
}
