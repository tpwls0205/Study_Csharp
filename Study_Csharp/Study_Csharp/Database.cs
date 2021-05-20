using System.IO;
using System;
using Microsoft.VisualBasic;

namespace Study_Csharp
{
    public class Database
    {

        #region 정보알기 DirectoryInfo, FileInfo

        // 디렉토리 생성
        private readonly string _currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_currentDirectory + @"\data");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine("디렉토리가 생성되었습니다");
            }
            Console.WriteLine("생성 경로 : {0}", directoryInfo.FullName);
        }

        #endregion

        #region 파일 입출력 StreamWriter, StreamReader
        
        // 파일에 내용 입력해보기
        public void Run2()
        {
            using var sw = new StreamWriter(_currentDirectory + @"\data\log.txt", true);
            sw.WriteLine("프로그램 실행 시간: {0}", DateTime.Now);
        }

        #endregion

        #region 파일에 내용 출력

        public void Run3()
        {
            FileInfo fileInfo = new FileInfo(_currentDirectory + @"\data\log.txt");
            
            Console.WriteLine("저장경로 : {0}", fileInfo.DirectoryName);
            Console.WriteLine("파일명 : {0}", fileInfo.Name);
            
            Console.WriteLine("=== 파일 내용 ===");
            using var sr = new StreamReader(fileInfo.FullName);
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        #endregion
        
    }
}