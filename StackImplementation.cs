using System;
class Program
{
	static int[] stack=new int[1000];
	static int top=-1;
public static void Push(int data)
{
if(top>stack.Length)
{
	Console.WriteLine("Stack Overflow");
	
}
else
{
	stack[++top]=data;
	}
}
public static int Pop()
{
	if(top<0)
	{
		Console.WriteLine("Empty Stack");
		return -1;
	}
	else
	{
		return stack[top--];
	}
}
public static void  Peek()
{
	if(top<0)
	{
	Console.WriteLine("Empty Stack");

	}
	else
	{
		Console.WriteLine(stack[top]);
	}
}
public static void PrintStack()
{
	for(int i=0;i<=top;i++)
	{
				Console.WriteLine(stack[i]);

	}
}




static void Main(string[] args)
{
	Push(10);
	Push(20);
	Push(30);
	Push(50);
	Push(60);
	Push(100);
	PrintStack();
	Pop();
	PrintStack();
    Peek();



}

}