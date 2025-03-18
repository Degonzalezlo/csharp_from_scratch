

class Program
{
    static void Main()
    {
        /*1.POSITIVE POWER*/
       /* Console.Write("Por favor, ingresa un número: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int numero))
        {
            if (numero > 0)
            {
                int resultado = numero * numero;
                Console.WriteLine($"El resultado es: {resultado}");
            }
            else if (numero == 0)
            {
                Console.WriteLine("El resultado es: 0");
            }
            else
            {
                Console.WriteLine("Número negativo.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }

        Console.ReadLine();

       /* 2.DOUBLE O TRIPLE*/
       /* Console.Write("Por favor, ingresa el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Por favor, ingresa el segundo número: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int numero1) && int.TryParse(input2, out int numero2))
        {
            int resultado = CalcularDobleTriple(numero1, numero2);
            Console.WriteLine($"El resultado es: {resultado}");
        }
        else
        {
            Console.WriteLine("Por favor, ingresa números válidos.");
        }

        Console.ReadLine();

        /*3 .CALCULAR RAIZ CUADRADA*/
        /*
        Console.WriteLine("Por favor, ingresa un número: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double numero))
        {
            double resultado = CalcularRaizCuadrado(numero);
            Console.WriteLine($"El resultado es: {resultado}");
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }

        Console.ReadLine();

        /*4.CIRCLE PERIMETER*/
        /*Console.WriteLine("Por favor, ingresa el radio del círculo: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double radio))
        {
            if (radio >= 0){
                double perimetro = CalcularPerimetroCirculo(radio);
                Console.WriteLine($"El perímetro del círculo es: {perimetro:F2}");
            }else{
                Console.WriteLine("El radio no puede ser negativo.");
            }
        }else{
            Console.WriteLine("Por favor, ingresa un número válido.");
        }

        Console.ReadLine();
        /*5.MIDEWEEK DAY*/
        /*Console.WriteLine("Por favor, ingresa un número entre 1 y 7: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dia))
        {
            string resultado = ObtenerDiaLaboral(dia);
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }

        Console.ReadLine();
        /*6.TAX CACULATOR*/
        /*Console.WriteLine("Por favor, ingresa tu salario anual: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double salario))
        {
            string resultado = CalcularImpuesto(salario);
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }

        Console.ReadLine();
        /*7.REMAINDER FINDER*/
        /*Console.WriteLine("Por favor, ingresa el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Por favor, ingresa el segundo número: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int numero1) && int.TryParse(input2, out int numero2))
        {
            if (numero2 != 0){
                int residuo = CalcularResiduo(numero1, numero2);
                Console.WriteLine($"El residuo es: {residuo}");
            }else{
                Console.WriteLine("No se puede dividir por cero.");
            }
        }else{
            Console.WriteLine("Por favor, ingresa números válidos.");
        }

        Console.ReadLine();
        /*8.SUM OF EVENS*/
        /*int sumaPares = CalcularSumaPares(1, 50);
        Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {sumaPares}");
        Console.ReadLine();

        /*9.FRACTION DIFFERENCE*/
        /*Console.WriteLine("Por favor, ingresa la primera fracción (num/den): ");
        string[] partes1 = Console.ReadLine().Split('/');
        Console.WriteLine("Por favor, ingresa la segunda fracción (num/den): ");
        string[] partes2 = Console.ReadLine().Split('/');

        if (int.TryParse(partes1[0], out int num1) && int.TryParse(partes1[1], out int den1) &&
            int.TryParse(partes2[0], out int num2) && int.TryParse(partes2[1], out int den2))
        {
            if (den1 != 0 && den2 != 0)
            {
                string resultado = CalcularDiferenciaFracciones(num1, den1, num2, den2);
                Console.WriteLine($"La diferencia es: {resultado}");
            }else{
                Console.WriteLine("No se puede dividir por cero.");
            }
        }else{
            Console.WriteLine("Por favor, ingresa fracciones válidas.");
        }

        Console.ReadLine();
        /*10.STRING LENGHT*/
        /*Console.WriteLine("Por favor, ingresa una palabra: ");
        string palabra = Console.ReadLine();

        int longitud = palabra.Length;
        Console.WriteLine($"La longitud de la palabra es: {longitud}");

        Console.ReadLine();
        /*11.AVERAGE OF FOUR*/
        /*Console.WriteLine("Por favor, ingresa el primer número: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("Por favor, ingresa el segundo número: ");
        string input2 = Console.ReadLine();

        Console.WriteLine("Por favor, ingresa el tercer número: ");
        string input3 = Console.ReadLine();

        Console.WriteLine("Por favor, ingresa el cuarto número: ");
        string input4 = Console.ReadLine();

        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2) &&
            double.TryParse(input3, out double num3) && double.TryParse(input4, out double num4))
        {
            double promedio = CalcularPromedio(num1, num2, num3, num4);
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }else{
            Console.WriteLine("Por favor, ingresa números válidos.");
        }

        Console.ReadLine();
        /*SMALLEST OF FIVE*/
        /*Console.WriteLine("Por favor, ingresa el primer número: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("Por favor, ingresa el segundo número: ");
        string input2 = Console.ReadLine();

        Console.WriteLine("Por favor, ingresa el tercer número: ");
        string input3 = Console.ReadLine();

        Console.WriteLine("Por favor, ingresa el cuarto número: ");
        string input4 = Console.ReadLine();

        Console.WriteLine("Por favor, ingresa el quinto número: ");
        string input5 = Console.ReadLine();

        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2) &&
            double.TryParse(input3, out double num3) && double.TryParse(input4, out double num4) &&
            double.TryParse(input5, out double num5))
        {
            double menor = CalcularMenor(num1, num2, num3, num4, num5);
            Console.WriteLine($"El número más pequeño es: {menor}");
        }
        else
        {
            Console.WriteLine("Por favor, ingresa números válidos.");
        }

        Console.ReadLine();
        /*13.VOWEL COUNTER*/
        /*Console.WriteLine("Por favor, ingresa una palabra: ");
         string palabra1 = Console.ReadLine();

        int vocales = ContarVocales(palabra1);
        Console.WriteLine($"La palabra tiene {vocales} vocales.");

        Console.ReadLine();
        /*14.FACTORIAL FINDER*/
         /*Console.WriteLine("Por favor, ingresa un número: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            if (numero >= 0)
            {
                long factorial = CalcularFactorial(numero);
                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }else{
                Console.WriteLine("El factorial no está definido para números negativos.");
            }
        }else{
            Console.WriteLine("Por favor, ingresa un número válido.");
        }

        Console.ReadLine();
        /*15.INRANGE VALIDATOR*/
        Console.WriteLine("Por favor, ingresa un número: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            string resultado = ValidarRango(numero);
            Console.WriteLine(resultado);
        }else{
            Console.WriteLine("Por favor, ingresa un número válido.");
        }

        Console.ReadLine();
        

    }

/*METHODS*/
    static int CalcularDobleTriple(int num1, int num2)
    {
        if (num1 > num2){
            return num1 * 2; 
            }
        else{
            return num2 * 3; 
            }
    }

    
    static double CalcularRaizCuadrado(double numero)
    {
        if (numero > 0){
            return Math.Sqrt(numero); // Devuelve la raíz cuadrada
        }
        else if (numero == 0){
            return 0; // La raíz cuadrada de 0 es 0
        }
        else{
            return Math.Pow(numero, 2); // Devuelve el cuadrado
        }
    }

    static double CalcularPerimetroCirculo(double radio)
    {
        const double pi = Math.PI;
        return 2 * pi * radio;
    }

    static string ObtenerDiaLaboral(int dia)
    {
        string[] diasLaborales = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

        if (dia >= 1 && dia <= 5){
            return diasLaborales[dia - 1]; // Resta 1 por que el indice comienza en 0
        }else{
            return "Número fuera del rango laboral.";
        }
    }
    static string CalcularImpuesto(double salario)
    {
        const double limite = 12000;
        const double tasaImpuesto = 0.15;

        if (salario > limite) {
            double excedente = salario - limite;
            double impuesto = excedente * tasaImpuesto;
            return $"Debe pagar un impuesto de {impuesto:F2}";//Se redondea a dos decimales.
        }else{
            return "No debe impuestos.";
        }
    }

    static int CalcularResiduo(int dividendo, int divisor)
    {
        return dividendo % divisor;
    }

    static int CalcularSumaPares(int inicio, int fin)
    {
        int suma = 0;
        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }
        return suma;
    }

    static string CalcularDiferenciaFracciones(int num1, int den1, int num2, int den2)
    {
        // Calcula el mínimo común múltiplo (MCM) de los denominadores
        int mcm = CalcularMCM(den1, den2);

        // Convierte las fracciones al mismo denominador
        int num1Conv = num1 * (mcm / den1);
        int num2Conv = num2 * (mcm / den2);

        // Calcula la diferencia
        int diferenciaNum = num1Conv - num2Conv;

        // Simplifica la fracción si es posible
        string resultado = SimplificarFraccion(diferenciaNum, mcm);

        return resultado;
    }

    static int CalcularMCM(int a, int b)
    {
        return (a * b) / CalcularMCD(a, b);
    }

    static int CalcularMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static string SimplificarFraccion(int numerador, int denominador)
    {
        int mcd = CalcularMCD(numerador, denominador);
        int numSimplificado = numerador / mcd;
        int denSimplificado = denominador / mcd;

        if (numSimplificado == 0)
        {
            return "0";
        }else if (denSimplificado == 1){
                return numSimplificado.ToString();
        }else{
            return $"{numSimplificado}/{denSimplificado}";
        }
    }

    static double CalcularPromedio(double num1, double num2, double num3, double num4)
    {
        return (num1 + num2 + num3 + num4) / 4;
    }

     static double CalcularMenor(double num1, double num2, double num3, double num4, double num5)
    {
        double[] numeros = { num1, num2, num3, num4, num5 };
        double menor = numeros[0];

        foreach (double numero in numeros)
        {
            if (numero < menor)
            {
                menor = numero;
            }
        }

        return menor;
    }

    static int ContarVocales(string palabra1)
    {
        int contador = 0;
        string vocales = "aeiouAEIOU";

        foreach (char letra in palabra1)
        {
            if (vocales.IndexOf(letra) != -1)
            {
                contador++;
            }
        }

        return contador;
    }

     static long CalcularFactorial(int numero)
    {
        long resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    static string ValidarRango(int numero)
{
    if (numero is >= 10 and <= 20)
    {
        return "Está en el rango.";
    }else{
        return "Fuera del rango.";
    }
        
    
}

}
