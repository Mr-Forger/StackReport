using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackReport
{
    internal class ArrayStack
    {
        static void Main(string[] args)
        {
            int[] stack = new int[100];
            int top = -1; // top은 최초 노드 삽입 위치
            stack[++top] = 5; //push
            stack[++top] = 9; //push
            stack[++top] = 1; //push

            for (int i = 0; i <=top; i++)
            {
                Console.WriteLine(stack[i]);
            }
            Console.WriteLine();
            Console.WriteLine("삭제시킨 값은:" + stack[top--]); // pop
            Console.WriteLine("아래는 남은 배열입니다.");
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
