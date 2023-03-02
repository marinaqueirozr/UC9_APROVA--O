string[,] cadastro = new string[5,7];
int i = 0;
string nome = "";

for(i = 0; i <= 4; i++)
{
    Console.WriteLine("Cadastre o nome do aluno(a)");
    nome = Console.ReadLine();
}
for (i = 0;i <= 4; i++)
{
    Console.WriteLine(nome + " - ");
}



