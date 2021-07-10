namespace Study_Csharp
{
    public class Array
    {
        
        #region Remove와 RemoveAt차이

        /*
         * Remove와 RemoveAt
         * Remove는 값 매칭
         * RemoveAt은 인덱스 매칭
         * Remove(1)은 배열에서 1이라는 값을 0번 인덱스부터 찾아 가장 처음 나온 배열을 삭제
         * RemoveAt(1)은 배열에서 1번 인덱스에 해당하는 요소를 삭제
         */

        #endregion

        #region ArrayList, Queue, Stack, Hashtable

        /*
         * ArrayList(어레이 리스트)
         * 추가 : ArrayList.Add
         * 출력 : ArrayList[index]
         * ArrayList는 제네릭(자료형)을 정해두지 않는다 (모든 타입을 담을 수 있다)
         * ArrayList는 배열을 크기를 사전에 정해두지 않는다 (동적 배열)
         * 
         * Queue(큐)
         * 추가 : Queue.Enqueue
         * 출력 : Queue.Dequeue
         * 큐는 선입선출 : 먼저 들어간 요소가 먼저 나감
         * 
         * Stack(스택)
         * 추가 : Stack.Push
         * 출력 : Stack.Pop
         * 스택은 후입선출 : 나중에 들어간 요소가 먼저 나감
         *
         * Hashtable(해시테이블)
         * 추가 : Hashtable.Add
         * 출력 : Hashtable[Key]
         * 해시테이블은 Key, Value 조합
         */

        #endregion

        #region Boxing과 UnBoxing

        /*
         * Boxing : 값 형태의 데이터를 참조 형식으로 변환
         * -> 메모리를 힙 영역에 생성
         * UnBoxing : 참조 형태의 타입을 실제 값 형식으로 변환
         */

        #endregion

        #region Generic타입 Collection
        
        /*
         * ArrayList => List<T>
         * Queue => Queue<T>
         * Stack => Stack<T>
         * Hashtable => Dictionary<T,T>
         */

        #endregion
        
    }
}