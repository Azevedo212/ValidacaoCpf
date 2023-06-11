public class Pessoa
{
    private string nome;
    private string cpf;
    private string idade;
    private string sexo;
    private double peso;
    private double altura;

    public Pessoa(string nome, string cpf, string idade, string sexo, double peso, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public string Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public (string, string, double) CalcularIMC()
    {
        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            string classificacao = "magreza";
            string grau = "0";
            return (classificacao, grau, imc);
        }

        if (imc >= 18.5 && imc <= 24.9)
        {
            string classificacao = "normal";
            string grau = "0";
            return (classificacao, grau, imc);
        }

        if (imc >= 25.0 && imc <= 29.9)
        {
            string classificacao = "sobrepeso";
            string grau = "I";
            return (classificacao, grau, imc);
        }

        if (imc >= 30.0 && imc <= 39.9)
        {
            string classificacao = "obesidade";
            string grau = "II";
            return (classificacao, grau, imc);
        }

        else
        {
            string classificacao = "obesidade grave";
            string grau = "III";
            return (classificacao, grau, imc);
        }
    }
}
