# Roteiro das Aulas

# 14/04/2023
- Apresentação da turma, colegas e habilidades
    - Alexandre Zamberlan - https://github.com/alexandrezamberlan
    - alexz@ufn.edu.br
    - Turma heterogênea com habilidade adequada de programação

- Boas práticas de trabalho em equipe na computação
    1) Versionamento de código
        - https://visualstudio.microsoft.com/pt-br/free-developer-offers/
        - Para sincronizar VS Code ou VS 2022 com GitHub é preciso:
            1) instalar o git na máquina
            2) no VS Code - instalar a extensão GitLens
            3) primeiro, criar o projeto no github, segundo, clonar na sua máquina, alterar e sincronizar
                - o primeiro sincronismo deve validar com usuário e senha na WEB

    2) Consultar fontes da microsoft de preferência
        - https://docs.microsoft.com/pt-br/dotnet/csharp/
        - https://www.w3schools.com/cs/index.php

- Ambientes de Desenvolvimento (IDE)
    1) Visual Studio 2022 - https://visualstudio.microsoft.com/pt-br/free-developer-offers/
    2) Visual Studio Code - https://visualstudio.microsoft.com/pt-br/free-developer-offers/
    3) Git - https://git-scm.com/downloads
    4) SQL Server - https://www.microsoft.com/pt-br/sql-server/sql-server-downloads

- Tipos estruturados
    - MATRIZES                  0        1       2       3
        - 1 DIMENSÃO -> vetorI [1        8       9       98]
                        vetorS ["Ana"    "Bia"  "Carlos", "Pedro"]
                        vetorD [3.8,     8.9,    9.8,    5.7]

                        //declaração
                        int[] vetorI = new int[4];
                        string[] vetorS = new string[4];
                        double[] vetorD = new double[4];

                        //acesso direto ou randomizável
                        vetorI[0] = 15
                        if (vetorS[1] == "Bia") {

                        }
                        vetorD[3] = vetorD[3] * 2.4;
    
                        //percorrer 
                        for (int i = 0; i < vetorI.length; i++) {
                            Console.WriteLine(vetorI[i]);
                        }
                                                
                        //Listas = Coleções com características de vetores dinâmicos
                        Exemplos:
                            - List
                            - LinkedList
                            - Hash

        2 DIMENSÕES -> comumente chamado de matriz ou array
            - relação de linhas por colunas
            matrizI
            [
                1   5   4   8
                33  6   1   7
                98  4   2   9
            ]

            matrizS
            [
                "ana"   "pedro" "sofia"
                "bruno" "rafa"  "joa"
            ]


            //declaração
            int[,] matrizI = new int[3,4];
            string[,] matrizS = new string[2,3];

            //acessando direto a linha 1 e coluna 3
            matrizI[1,3] = 999;

            if (matrizS[0,1] == "joca") {

            }
            

            //
            matrizI
            [
                0  0   0  0
                0  0   0  0
                0  0   0  0
            ]
            Random gerador = new Random();
            for (int i = 0; i < 3; i++) {       //for externo é para as linhas
                for (int j = 0; j < 4; j++) {   //for interno é para as colunas
                    matrizI[i,j] = matriz[i,j] * 3;
                }
            }
                        
                            