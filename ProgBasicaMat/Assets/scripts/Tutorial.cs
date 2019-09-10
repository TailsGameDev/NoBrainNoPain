//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//se quiser execute esse codigo no rextester.com

//login pro github:
//alunoscgames
//scgames1234

//Apostila Unity:
// https://docs.google.com/document/d/1UXQjldUH9oJnsKJxCcb9MM7sA7Qga_Zj4zAythm82zI/edit?usp=sharing

namespace Rextester {
    public class Program {
        public static void Main (string[] args) {
            
            //na Unity eh soh print("texto para imprimir");
            Console.WriteLine("Hello, World!");

            //criar variavel
            string primeiraVariavel = "Caina ";
            string textoPraConcatenar = "eh um bom professor";

            // concatenação:
            Console.WriteLine(primeiraVariavel + textoPraConcatenar + ".\nVc nao acha?");

            //matematicas

            var meuDouble = 10.5; // declarando double, mas usando 'var'

            float meuFloat = 20.3f; // float eh numero com virgula, soh que usa menos espaço na memoria que um double.
                                    //tem que colocar um 'f' depois de um numero float pro compilador entender que eh float e nao double.

            Console.WriteLine(meuDouble * meuFloat);
            // alem de multiplicacao ( * ) temos: + - /

            //variavel booleana
            bool celularFazContas = true;
            bool dispositivo2FazContas = false;
            // && eh a mesma coisa que o operador 'e' ; || eh a mesma coisa que o operador 'ou'
            Console.WriteLine("operacao ou: " + (celularFazContas || dispositivo2FazContas));

            //concicionais
            if (dispositivo2FazContas) {
                //soh vai executar isso se o dispositivo2FazContas
                Console.WriteLine("O dispositivo 2 faz contas. Yeah");
            } else if (celularFazContas) {
                Console.WriteLine("Tah, tranquilo: o celular faz a conta... ufa");
            } else {
                Console.WriteLine("Lascou! Como vamos fazer a conta? Socorroooooooo");
            }

            var meuInt = 0;

            switch (meuInt) {
                case 0:
                    Console.WriteLine("meu Int vale 0");
                    break;
                case 1:
                    Console.WriteLine("meu Int vale 1");
                    break;
                case 2:
                    Console.WriteLine("meu Int vale 2");
                    break;
                case 3:
                    Console.WriteLine("meu Int vale 3");
                    break;
                default:
                    Console.WriteLine("meu Int vale um negocio que eu nao estava esperando");
                    break;
            }

            string testString;
            testString = Console.ReadLine();
            Console.WriteLine("Input coletado " + testString);

            int iterador = 5;
            // mais opções: > , < , >= , <= , == (igual), != (diferente)
            while (iterador > 0) {
                Console.WriteLine("Repetindo com while: " + iterador);
                iterador = iterador - 1; // eh igual a escrever iterador--;
            }
            Console.WriteLine("eu saí do loop, yeah");

            for (int i = 6 ; i > 0 ; i-- /*i = i+1*/) {
                Console.WriteLine("Repetindo com for: " + i);
            }

            // criando vetor
            int[] meus5Numeros = {2,4,3,2,5};
            int[] numeros = new int[999];

            // usa um elemento do vetor
            Console.WriteLine(numeros[2]);

            numeros[2] = 4; // modifica um elemento do vetor
            Console.WriteLine(numeros[2]);

            //quantos elementos tem no vetor?
            Console.WriteLine(numeros.Length);

            //funcoes!

            ImprimeVariasCoisas();

            //Dah pra usar funcao para criar vetor!
            int[] vetorCriadoComFuncao = CriaVetor();
            Console.WriteLine(vetorCriadoComFuncao.Length);

            int x = 1; int y = 2; int z = 9;
            int soma = Soma3Numeros(x,y,z);
            Console.WriteLine("3 numeros somados com funcao: " + soma);

            //classes:
            //classes sao formadas por atributos e metodos.

            //criando um objeto
            Guerreiro caina = new Guerreiro();

            //alterando atributos publicos
            caina.ataque = 20;
            caina.vida = 100;

            // usando atributo publico
            Console.WriteLine(caina.ataque);

            //criando mais um guerreiro
            Guerreiro guerreiro = new Guerreiro( "Joao" );

            Console.WriteLine("vida do " + guerreiro.nome + ": " + guerreiro.vida);

            caina.Atacar(guerreiro);

            Console.WriteLine("vida do " + guerreiro.nome + ": " + guerreiro.vida);

            //criando objeto da subclasse Berseker, que herda de Guerreiro
            Berseker brutus = new Berseker("Brutus");

            brutus.Atacar(guerreiro);

            Console.WriteLine("vida do " + guerreiro.nome + ": " + guerreiro.vida);

            Console.WriteLine("nome do berseker: " + brutus.nome);
        }

        //criando funcao
        static void ImprimeVariasCoisas () {
            Console.WriteLine("imprimir um negocio");
            Console.WriteLine("imprimir um negocio");
            Console.WriteLine("imprimir um negocio");
            Console.WriteLine("imprimir um negocio");
            Console.WriteLine("imprimir um negocio");
            Console.WriteLine("imprimir um negocio");
            Console.WriteLine("imprimir um negocio");
        }

        //funcao com retorno
        static int[] CriaVetor () {
            int[] vet = new int[5];
            return vet;
        }

        //criamos funcao com parametros e retorno.
        static int Soma3Numeros (int n1 , int n2 , int n3) {
            int variavel = n1+n2+n3;
            return variavel;
            //return n1+n2+n3;
        }

    }

    //criando uma classe
    public class Guerreiro {
        //atributos
        public int vida;
        public int ataque;
        public string nome;

        //construtor
        public Guerreiro () {
            vida = 100;
            ataque = 20;
        }

        public Guerreiro (string nomeDoGuerreiro) {
            this.nome = nomeDoGuerreiro;
            vida = 100;
            ataque = 20;
        }

        //metodos ...
        public virtual void Atacar (Guerreiro g) {
            g.vida = g.vida - ataque;
        }
    }

    //criando subclasse Berseker, que herda de guerreiro
    public class Berseker : Guerreiro {
        //construtor da subclasse chama o construtor da superclasse
        public Berseker () : base() {

        }

        //construtor da subclasse chama o construtor da superclasse com um parametro
        public Berseker (string name) : base(name) {

        }

        //escreve sobre o metodo da superclasse com palavra chave override
        public override void Atacar (Guerreiro g) {
            base.Atacar(g);
            base.Atacar(g);
        }
    }
}

