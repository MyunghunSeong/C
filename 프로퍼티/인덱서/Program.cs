using System;
using System.Threading;


/******************************************************************
*
*		인덱서 활용 예제
*	1. 파라미터 값을 받아 덧셈연산을 하는 함수 선언
*	2. 덧셈연산 인덱서 선언(프로퍼티를 활용한 설정 및 리턴)
*	3. 정수를 담을 수 있는 배열 선언
*	4. 배열 요소에 대한 인덱서 선언(프로퍼티 활용)
*	5. 인덱서를 이용한 덧셈 결과 출력
*	6. 배열 요소를 덧셈 결과 + 요소의 값으로 설정 및 출력
*
*******************************************************************/
class AddProgram
{
    public static readonly int SIZE = 10;
    /* === 1번 ===*/
    private int getResult(int x, int y) { return x + y; }
    private int[] dataArray;

    public AddProgram() { dataArray = new int[SIZE]; /* === 3번 === */}

    /* === 2번 === */
    public int this[int x, int y] { get { return getResult(x, y); } } //덧셈연산 인덱서

    /*=== 4번 ===*/
    public int this[int index]  //배열 요소 인덱서
    {
        get
        {
            return dataArray[index];

            if (dataArray.Length <= 0)
                throw new NullReferenceException(); //널 예외 처리

        }
        set
        {
            if (dataArray[index] < SIZE)
                dataArray[index] = value;
            else
                throw new IndexOutOfRangeException(); //오버플로우 예외 처리
        }
    }
}

public class Test
{
    public static void Main(String[] args)
    {
        AddProgram add = new AddProgram();

        int result = 0;

        result = add[2, 2];

        /* === 5번 === */
        Console.WriteLine("======= 덧셈 함수(인덱서 사용) =======");
        Console.WriteLine("덧셈 결과 = " + result.ToString());
        Console.WriteLine();


        Console.WriteLine("======= 배열 요소 설정 및 출력(인덱서 사용) =======");
        for (int i = 0; i < AddProgram.SIZE; i++)
        {
            add[i] = add[(i + 1), 5]; /* === 6번 === */
            Console.WriteLine(i + 1 + "번째 데이터 = " + add[i]);
        }
    }
}