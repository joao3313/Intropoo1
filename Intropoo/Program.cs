namespace introPOO1
{
    using System;

    //classe
    public class Pessoa
    {   
        //Atributos
        public string nome;
        public int idade;
        public double altura;
        public double peso;

        //metodo construtor
        public Pessoa(string nome, int idade, double altura,double peso)
        {
            //se utilizo o "this.nome", estou referindo ao atributo 
            //se utilizo o "nome", estou me referindo ao prametro metodol
         this.nome = nome;
         this.idade = idade;
         this.altura = altura;
         this.peso = peso;


        }


        //metodo para criar varios atributos
        public void exibeDados()
        {

            Console.WriteLine("Nome: " +  nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " +altura);
            Console.WriteLine("Peso: " +  peso);


        }
    }

    class Program
    {
        //criando um objeto a partir da classe pessoa
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Joao", 28,1.80,56.0);
            Pessoa p2 = new Pessoa("Marcos",32,1.80,56.0);

            //passando o atributo nome para o objeto P1
           // p1.nome = "Joao";
           // p1.idade = 28;
           // p1.altura = 1.80;
           // p1.peso = 56.0;


            //mostrar no console o que tem guardado no nome para P1
           // Console.WriteLine("Nome: " +   p1.nome);
           // Console.WriteLine("Idade: " + p1.idade);
           // Console.WriteLine("Altura: " + p1.altura);
           //// Console.WriteLine("Peso: " + p1.peso);

            Console.WriteLine();
            //passando o atributo nome para o objeto P2
           // p2.nome = "Marcos";
           // p2.idade = 32;
           // p2.altura = 1.80;
           // p2.peso = 56.0;

            p1.exibeDados ();
            Console.WriteLine();
            p2.exibeDados ();
            Console.WriteLine();

            //mostrar no console o que tem guardado no nome para P2
           // Console.WriteLine("Nome: " + p2.nome);
           // Console.WriteLine("Idade: " + p2.idade);
           // Console.WriteLine("Altura: " + p2.altura);
           // Console.WriteLine("Peso: " + p2.peso);

            



        }
    }
}
