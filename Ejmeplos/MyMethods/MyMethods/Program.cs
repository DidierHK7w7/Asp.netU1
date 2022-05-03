using System;

public class MyMethods
{
	/*
	 * Ahora conoces cómo crear y utilizar tus propios métodos.
	 * Como reto de esta clase crea un método que ejecute la división de dos números.
	 * Como tip toma en cuenta que la mayoría de las divisiones no dan resultados enteros,
	 * por lo que necesitarás definir tu método y variables con otro tipo de dato.
	 */
	//Reto
	public float IntegerDivition(int a, int b)
	{
		float divition = a / b;
		return divition;
	}



	public void IntegerAddition(int a, int b)
	{
		int Addition = a + b;
		Console.WriteLine("El resultado es " + Addition);
	}

	public int IntegerMultiplication(int a, int b)
	{
		int Multiplication = a * b;
		return Multiplication;
	}


	public static void Main()
	{
		MyMethods MyProgram = new MyMethods();

		//MyProgram.IntegerAddition(1, 2);
		//Console.WriteLine("El resultado de la multiplicación es " + MyProgram.IntegerMultiplication(5, 2));

		Console.WriteLine("El resultado de la división es " + MyProgram.IntegerDivition(10, 2));
	}
}