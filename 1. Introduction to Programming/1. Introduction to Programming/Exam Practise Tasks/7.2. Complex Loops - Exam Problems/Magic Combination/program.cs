using System;
public class Program
{
	public static void Main()
	{
		var magic = int.Parse(Console.ReadLine());
		for(int n1 = 0; n1<magic; n1++)
        {
			for (int n2 = 0; n2 <= magic; n2++)
            {
				for (int n3 = 0; n3 <= magic; n3++)
                {
					for (int n4 = 0; n4 <= magic; n4++)
                    {
						for (int n5 = 0; n5 <= magic; n5++)
                        {
							for (int n6 = 0; n6 <= magic; n6++)
                            {
								if((n1*n2*n3*n4*n5*n6)==magic)
                                {
									Console.WriteLine($"{n1}{n2}{n3}{n4}{n5}{n6}");
                                }
                            }

						}

					}

				}

			}

		}
	}
}
