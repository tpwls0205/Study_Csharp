using System;
using System.Globalization;

namespace Study_Csharp
{
    public class Variable
    {
        public void Run()
        {
            
            #region object, var, dynamic 차이
            
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";

            bool isContainsWord01 = objHello.ToString().Contains("Hello");
            bool isContainsWord02 = vHello.ToString().Contains("Hello");
            bool isContainsWord03 = dHello.ToString().Contains("Hello");

            /*
             * object 타입은 모든 변수를 담을 수 있지만, 데이터가 정확히 무슨 타입인지 알 수 없다
             * var 타입은 모든 변수를 담을 수 있으며, 데이터가 정확히 무슨 타입인지 알 수 있다 but 컴파일 타입(중간에 자료형을 변경 못함)
             * dynamic 타입은 모든 변수를 담을 수 있으며, 데이터가 정확히 무슨 타입인지 알 수 있다 but 런타임 타입(중간에 자료형 변경 가능)
             */
            
            #endregion
            
            #region 형변환 Parse, Convert

            Convert.ToDouble("10");
            Double.Parse("10");
            /*
             * Parse와 Convert 둘 다 형변환을 위해 사용된다
             * 둘의 차이는 null 값에 대하여
             * Parse의 경우 에러를 반환
             * Convert의 경우 0을 반환
             */

            #endregion
            
        }
    }
}