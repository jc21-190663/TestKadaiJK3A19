using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetGo
{
    public class JetCoaster
    {
        public static int ride(int k, int[] g, int r)
                            //（定員人数、行列、回数
        {
            
            int num = 0;
            int result = 0;

            //jetに乗る回数分ループ
            while(r > 0)
            {
                int i = 0;
                //出発のカウント
                int sv_num = num;

                //定員分ループ、定員k
                while (i <= k)
                {

                    //変数iにg[num]番目の要素を加算
                    i += g[num];

                    //iが定員kより大きかったら
                    if (i > k)
                    {
                        //定員オーバーした変数iから上の処理で加算したg[num]の値を引く
                        i -= g[num];

                        //resultにiを代入
                        result += i;

                        //定員オーバーしたのでこの回は終わり
                        break;
                    }

                    //店員オーバーしていない場合numを加算
                    num ++;

                    //numが配列g[]より大きいか？
                    if (num > g.Length - 1)
                    {
                        num = 0;
                    }
                    if (sv_num==num)
                    {
                        //resultにiを代入
                        result += i;
                        break;
                    }
                }

                //jetの回数w
                r --;
            }
            return result;
        }
    }
}