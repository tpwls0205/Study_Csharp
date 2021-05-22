using System.Collections.Generic;

namespace Study_Csharp
{
    public class Lamda
    {

        #region 람다식

        /*
         * (매개변수 형태) => (리턴 형식)
         * 함수형 프로그래밍 : 코드를 소설 책 읽듯이!
         * 람다식은 '.'을 기준으로 해석 및 적용
         */

        #endregion

        #region 딕셔너리 value값 추가

        public void Test()
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary[list[0]] = dictionary[list[0]] + 1;
        }

        #endregion
    }
}