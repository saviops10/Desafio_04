using System;
using System.Collections.Generic;

public class Aluno
{
    public string nome;
    public int idade;
    public double nota;


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