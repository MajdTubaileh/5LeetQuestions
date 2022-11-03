// See https://aka.ms/new-console-template for more information

static class Constant
{
	public const int size = 1000;
}
class Program
{
	public static  void Main()
    {
		Stack s = new Stack(); ;
		s.push(5);
		s.push(6);
		s.push(7);
		s.push(8);
		s.peek();
		s.pop();
		

		s.Print_ALL();


		s.Clear();

		s.Print_ALL();
	}
}

public class Stack
{
private int top;
	
		
	int []a = new int[Constant.size];
	public Stack() { top = -1; }
	public bool push(int x)
    {
		if (top >= (Constant.size - 1))
		{
			Console.WriteLine("Stack full");
			return false;
		}
		else
		{
			a[++top] = x;
			Console.WriteLine( x + " pushed into the stack");
			return true;
		}
	}
	private bool pushP(int x)
	{
		if (top >= (Constant.size - 1))
		{
			Console.WriteLine("Stack full");
			return false;
		}
		else
		{
			a[++top] = x;
			
			return true;
		}
	}
	public int pop()
    {

		if (top < 0)
		{
			Console.WriteLine("Stack empty");

			return 0;
		}
		else
		{

			int x = a[top--];
			Console.WriteLine(x + " popped from the stack");
			return x;
		}
	}
	private int popP()
	{

		if (top < 0)
		{
			Console.WriteLine("Stack empty");

			return 0;
		}
		else
		{

			int x = a[top--];
			
			return x;
		}
	}
	public int peek()
    {
		if (top < 0)
		{
			Console.WriteLine("Stack empty");
			return 0;
		}
		else
		{
			int x = a[top];
			Console.WriteLine(x + " peek of the stack");
			return x;
		}
	}
	private int peekP()
	{
		if (top < 0)
		{
			Console.WriteLine("Stack empty");
			return 0;
		}
		else
		{
			int x = a[top];
			return x;
		}
	}
	public void Print_ALL()
    {
		Stack temp = new Stack();	
		if(empty())
        {
			Console.WriteLine("Stack empty");
			return;
        }
		while(!empty())
        {
			temp.pushP(this.peekP());
			this.popP();
        }
		Console.WriteLine("Stack elements");
		while (!temp.empty())
        {
			int x = temp.peekP();
			Console.Write(x + "  ");
			temp.popP();
			this.pushP(x);
        }
		Console.WriteLine();
    }
	public void Clear()
    {
		Console.WriteLine("Clearing out the stack right now ..");
		while(!this.empty())
        {
			this.pop();
        }
		if(this.empty())
        {
			Console.WriteLine("Stack cleared.");
        }
    }
	public bool empty()
    {
		return (top < 0);
	}
}



