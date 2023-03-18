class program
{
		public static void Main()
{
		int x,y,z;
		int total;
		double avg;
			x=int.Parse(System.Console.ReadLine());
			y=int.Parse(System.Console.ReadLine());
			z=int.Parse(System.Console.ReadLine());
			total=x+y+z;
			avg=total\3;
			System.Console.WriteLine("avg");
			if(avg>60)
			{
				System.Console.WriteLine("A grade");
 			}
			else if(avg>50)
			{
				
				System.Console.WriteLine("B grade");
			}
			else if(avg>40)
			{
				System.Console.WriteLine("C grade");
			}
			else
			{
				System.Console.WriteLine("fail");
			}
}

}