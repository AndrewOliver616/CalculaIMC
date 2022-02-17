            float A, P, imc;
            Console.WriteLine("Olá, seja bem-vindo ao App de Calculo de Massa Corpórea - IMC");
            Console.WriteLine("Digite o seu peso: ");
            P = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura com vírgula: ");
            A = float.Parse(Console.ReadLine());
            


            //A= Altura, P = Peso

            imc = (P / (A*A));


            if (imc <= 18)
            {
                Console.WriteLine($"Seu IMC é :{imc}, você está abaixo do seu peso ideal");
            }
            if ((imc >= 18)&& (imc <= 25))
            {
                Console.WriteLine($"Seu IMC é: {imc} você está no seu peso ideal");
            }
            if ((imc >= 25) && (imc <= 28))
            {
                Console.WriteLine($"Seu IMC é: {imc} você está acima do seu peso ideal");
            }
            if ((imc >= 28) && (imc <= 35))
            {
                Console.WriteLine($"Seu IMC é: {imc} você está com obesidade grau I");
            }
            if ((imc >= 35) && (imc <= 40))
            {
                Console.WriteLine($"Seu IMC é: {imc} você está com obesidade grau II");
            }
            if (imc > 40)
            {
                Console.WriteLine($"Seu IMC é: {imc} você está com obesidade grau II");
            }
            Console.WriteLine("Não deixe de procurar um nutricista para uma correta orientação");
            Console.WriteLine("Aplicação executada com sucesso! Tecle ENTER para encerrar");
            Console.ReadLine();