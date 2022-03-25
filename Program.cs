using static System.Console;

WriteLine("Digite o nome do arquivo:");

var nome = ReadLine();

nome = LimparNome(nome);


var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
//variável path cria um arquivo do modelo txt neste caso

CriarArquivo(path);

WriteLine("Digite enter para finalizar!");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
    //um foreach para invalidar carcteres incorretos e junto com a variavel Limpar nome corrigir o arquivo
}
static void  CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Está a linha 1 do arquivo");
        sw.WriteLine("Está a linha 2 do arquivo");
        sw.WriteLine("Está a linha 3 do arquivo");
    }
    catch 
    {
        
        WriteLine("O nome do arquivo está inválido!");
    }
    

}



