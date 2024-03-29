﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Herenca;

Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1,
    "12906304",
    "Mario Miziara",
    91,
    "Sobral",
    "Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Fernando", "9913440447", e1);
Cliente c2 = new Cliente(2, "Vinicius", "991320000", e1);
Cliente c3 = new Cliente(3, "Fernando 2", "991586457", e1);
Cliente c4 = new Cliente(4, "Alexandre", "991123478", e1);
Cliente c5 = new Cliente(1, "Arthur", "994621879", e1);
Cliente c6 = new Cliente(1, "Lucas", "992601618", e1);



Console.WriteLine(c1.getEndereco().EnderecoCompleto()   );
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto()   );
c1.getEndereco().AtualizarEndereco("Julio de Moraes", 585, "Portal Itamaraca");
Console.WriteLine(c1.getEndereco().EnderecoCompleto()   );

Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadedeRodas = 4;
car.quantidadedeAssentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Azul";
bicicleta.quantidadedeRodas = 2;
bicicleta.quantidadedeAssentos = 1;
bicicleta.TemMotor = false;

Aviao airplane = new Aviao();
airplane.cor = "Branco";
airplane.quantidadedeRodas = 18;
airplane.quantidadedeAssentos = 340;
airplane.TemMotor = true;


List<Veiculo> veiculoLista = new List<Veiculo>();

veiculoLista.Add(car);
veiculoLista.Add(airplane);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("Qtd itens da Lista" + veiculoLista.Count);

Random rand = new Random();

List<Produto> produtoLista = new List<Produto>();
List<Cliente> clienteLista = new List<Cliente>();

for (int i=0;i<500;i++)
{
    int aux = 0;
    aux = 1 * 10;
    Produto p = new Produto(i, "Teste", aux);
    produtoLista.Add(p);
}


for (int i = 0; i < 250; i++)
{
    int aux = i * 3;    
    Cliente c = new Cliente(aux, "Fernando", "123456" , e1);
    clienteLista.Add(c);
}

foreach (var item in produtoLista)
{
    Console.WriteLine(item.ProdutoCompleto());
}

foreach (var item in clienteLista)
{
    Console.WriteLine(item.ClienteCompleto());
}






