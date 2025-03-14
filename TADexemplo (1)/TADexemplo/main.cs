using System;

public class Dragao{
    int mordida;
    int bolaFogo;
    int life;
    int recompensa;
public Dragao(int m, int b, int l, int r){
      mordida = m;
      bolaFogo = b;
      life = l;
      recompensa = r;
}
  
public void morder(){
    Console.WriteLine("Mordida!");
}
public void lancarFogo(){
  Console.WriteLine("Lançar bola de fogo!");
}
public void sofrerDano(int dano){
         life -= dano;
  if (life <= 0)
  Console.WriteLine("Dragão derrotado!");
  }
}

public class Heroi{
    int forca;
    int life;
    int moedas;
    int tipo; //1 para cavaleiro; 2 para mago
public Heroi(int f, int l, int m, int t){
     forca = f;
     life = l;
     moedas = m;
     tipo = t;
  }

public void atacar(){
  if(tipo==1)
    Console.WriteLine("Ataque com espada!");
  else
    Console.WriteLine("Ataque com magia!");
    }
public void sofrerDano(int dano){
     life -= dano;
if (life <= 0)
    Console.WriteLine("Herói morreu!");
 }
}

class Program {
static void Main (string[] args) {
//Criação dos objetos
    Heroi Cavaleiro = new Heroi(80,100,0,1);
    Heroi Mago = new Heroi(60,100,0,2);
    Dragao DragaoVermelho = new Dragao(70,110,100,30);
//Cavaleiro ataca Dragão
Cavaleiro.atacar();
//Dragão sofre dano do Cavaleiro
DragaoVermelho.sofrerDano(80);
//Dragão ataca Cavaleiro
DragaoVermelho.lancarFogo();
//Cavaleiro sofre dano do Dragão (morre)
Cavaleiro.sofrerDano(110);
//Mago ataca Dragão
Mago.atacar();
//Dragão sofre dano do Mago (morre)
DragaoVermelho.sofrerDano(60);
  }
 }
