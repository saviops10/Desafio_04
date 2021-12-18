using System;
using System.Collections.Generic;

public class Aluno   // definir classe e variaveis que serão utilizadas
{
    public string nome;
    public int idade;
    public double nota;

    // get = receber , set = alterar
    public string Nome { get; set; }  
    public int Idade { get; set; }
    public double Nota { get; set; }
    public Aluno(string nome, int idade, double nota)
    {
        Nome = nome;
        this.nome = nome;

        Idade = idade;
        this.idade = Idade;

        Nota = nota;
        this.nota = nota;
    }
}
