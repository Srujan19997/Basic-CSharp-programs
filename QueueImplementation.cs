using System;
class Program
{
	static int[] queue=new int[1000];
	static int rear=-1;
	static int front=0;
	public static void enqueue(int data)
	{
		if(rear>1000)
		{
			Console.WriteLine("Limit Exceded");
		}
		else
		{
			queue[++rear]=data;
		}
	}
	public static void dequeue()
	{
		if(front==rear)
		{
			Console.WriteLine("Empty Queue");
		}
		else
		{
			Console.WriteLine("{0} dequeued",queue[front++]);

		}


	}


	public static void printQueue()
	{
   if(front==rear+1)
   {
   	Console.WriteLine("Empty Queue");
   }
   else
   {
   	Console.WriteLine("Elements in Queue are :");
   	for(int i=front;i<=rear;i++)
   	{
   		Console.WriteLine(queue[i]);
   	}
   }
	}



	static void Main()
	{
		enqueue(10);
		enqueue(20);
		enqueue(30);
		enqueue(40);
		enqueue(50);
		printQueue();
		dequeue();
		printQueue();



	}
}