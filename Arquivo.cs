using
System;
class
Arquivo
{
    private string nome;
    private int numeroPaginas;

    public Arquivo (string nome, int numeroPaginas)
    {
        this.nome = nome;
        this.numeroPaginas = numeroPaginas;
    }

public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public int NumeroPaginas { 
        get { return numeroPaginas; }
        set { numeroPaginas = value; }
        }
public override String ToString()
    {
    return "[nome=" + nome + ", número de páginas=" + numeroPaginas + "]";
    }
}